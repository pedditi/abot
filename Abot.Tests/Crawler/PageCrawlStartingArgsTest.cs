﻿using Abot.Crawler;
using Abot.Poco;
using NUnit.Framework;
using System;

namespace Abot.Tests.Crawler
{
    public class PageCrawlStartingArgsTest
    {
        [Test]
        public void Constructor_ValidArg_SetsPublicProperty()
        {
            PageToCrawl page = new CrawledPage(new Uri("http://aaa.com/"));
            PageCrawlStartingArgs args = new PageCrawlStartingArgs(page);

            Assert.AreSame(page, args.PageToCrawl);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullArg()
        {
            new PageCrawlStartingArgs(null);
        }
    }
}