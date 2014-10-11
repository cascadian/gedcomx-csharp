﻿using FamilySearch.Api;
using FamilySearch.Api.Ft;
using Gx.Fs.Discussions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gedcomx.Rs.Api.Test
{
    [TestFixture]
    public class DiscussionsTests
    {
        private FamilySearchFamilyTree tree;

        [TestFixtureSetUp]
        public void Initialize()
        {
            tree = new FamilySearchFamilyTree(true);
            tree.AuthenticateViaOAuth2Password("sdktester", "1234sdkpass", "WCQY-7J1Q-GKVV-7DNM-SQ5M-9Q5H-JX3H-CMJK");
        }

        [Test]
        public void TestCreateComment()
        {
            var discussion = (DiscussionState)tree.AddDiscussion(new Discussion().SetTitle("Comment").SetDetails("Comment")).Get();
            var state = discussion.AddComment(new Comment().SetText("Comment"));

            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.AreEqual(HttpStatusCode.Created, state.Response.StatusCode);
        }

        [Test]
        public void TestReadComment()
        {
            var discussion = (DiscussionState)tree.AddDiscussion(new Discussion().SetTitle("Comment").SetDetails("Comment")).Get();
            discussion.AddComment(new Comment().SetText("Comment"));
            var state = discussion.LoadComments();

            Assert.DoesNotThrow(() => state.IfSuccessful());
            Assert.AreEqual(HttpStatusCode.OK, state.Response.StatusCode);
            Assert.IsNotNull(state.Discussion);
            Assert.IsNotNull(state.Discussion.Comments);
            Assert.Greater(state.Discussion.Comments.Count, 0);
        }
    }
}
