﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace TestProject
{
    [TestClass]
    public class Test
    {
        private TestHelper helper;
        [TestInitialize]
        public void TestInitialize()
        {
            helper = new TestHelper();
        }
        [TestCleanup]
        public void TestCleanup()
        {
            helper.CloseForm();
        }

        [TestMethod]
        public void Test1()
        {
            // 起動直後は起動中状態であることを確認
            Assert.AreEqual(false, helper.IsExecute_button_Enable());
            Assert.AreEqual(true, helper.StatusText().Contains("起動中"));

            // 起動完了待ち
            Thread.Sleep(1500);

            // 起動完了後のステータス確認
            Assert.AreEqual(true, helper.IsExecute_button_Enable());
            Assert.AreEqual(true, helper.StatusText().Contains("実行可能"));

            // 実行ボタン押下
            helper.PushExecute();

            // 実行直後のステータス確認
            Assert.AreEqual(false, helper.IsExecute_button_Enable());
            Assert.AreEqual(true, helper.StatusText().Contains("実行中"));

            // 実行完了待ち
            Thread.Sleep(1500);

            // 実行完了後のステータス確認
            Assert.AreEqual(true, helper.IsExecute_button_Enable());
            Assert.AreEqual(true, helper.StatusText().Contains("実行可能"));
        }
    }
}
