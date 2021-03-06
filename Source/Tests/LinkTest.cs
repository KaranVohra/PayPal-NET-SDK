﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayPal.Api;
using System.Collections.Generic;

namespace PayPal.Testing
{
    [TestClass()]
    public class LinksTest
    {
        public static readonly string LinksJson =
            "{\"href\":\"http://paypal.com/\"," +
            "\"method\":\"POST\"," +
            "\"rel\":\"authorize\"}";

        public static List<Links> GetLinksList()
        {
            var links = new List<Links>();
            links.Add(GetLinks());
            return links;
        }

        public static Links GetLinks()
        {
            return JsonFormatter.ConvertFromJson<Links>(LinksJson);
        }

        [TestMethod, TestCategory("Unit")]
        public void LinksObjectTest()
        {
            var link = GetLinks();
            Assert.AreEqual(link.href, "http://paypal.com/");
            Assert.AreEqual(link.method, "POST");
            Assert.AreEqual(link.rel, "authorize");
        }

        [TestMethod, TestCategory("Unit")]
        public void LinksConvertToJsonTest()
        {
            Assert.IsFalse(GetLinks().ConvertToJson().Length == 0);
        }

        [TestMethod, TestCategory("Unit")]
        public void LinksToStringTest()
        {
            Assert.IsFalse(GetLinks().ToString().Length == 0);
        } 
    }
}
