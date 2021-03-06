﻿using System;
using Engine;
using Katarai.StringCalculator.Interfaces;
using NUnit.Framework;

namespace Katarai.Acceptance.StringCalculator.Tests.NewTestWrittenWithoutAFailingTestForPreviousImplementation
{
    [Ignore("Because nunit 3.x needs this populated")]
    public class TestStringCalculator : ITestPack<IStringCalculator>
    {
        public Func<IStringCalculator> CreateSUT { get; set; }

		[SetUp]
        public void SetupTest()
        {
            CreateSUT = () => new StringCalculator();
        }
		
		private IStringCalculator CreateCalculator()
		{
			return CreateSUT();
		}
		
        /// <summary>
        /// This is a sample test that shows how the StringCalculator 
        /// should be created in future tests. 
        /// </summary>
        [Test]
        public void Constructor()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var calculator = CreateCalculator();
            //---------------Test Result -----------------------
            Assert.IsNotNull(calculator);
        }

    }

    [Ignore("Because nunit 3.x needs this populated")]
    public class TestStringCalculator_002 : ITestPack<IStringCalculator>
    {
        public Func<IStringCalculator> CreateSUT { get; set; }

		[SetUp]
        public void SetupTest()
        {
            CreateSUT = () => new StringCalculator();
        }
		
		private IStringCalculator CreateCalculator()
		{
			return CreateSUT();
		}
		
        /// <summary>
        /// This is a sample test that shows how the StringCalculator 
        /// should be created in future tests. 
        /// </summary>
        [Test]
        public void Constructor()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var calculator = CreateCalculator();
            //---------------Test Result -----------------------
            Assert.IsNotNull(calculator);
        }

        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add("");
            //---------------Test Result -----------------------
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_GivenNumberOne_ShouldReturnNumberOne()
        {
            //---------------Set up test pack-------------------
            var calculator = CreateCalculator();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = calculator.Add("1");
            //---------------Test Result -----------------------
            Assert.AreEqual(1, result);
        }
    }
}