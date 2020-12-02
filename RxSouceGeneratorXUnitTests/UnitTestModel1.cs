using Xunit;
using System;
using System.Reactive.Linq;
using RxMethodGenerator;
namespace RxSouceGeneratorXUnitTests
{
    public class UnitTestModel1
    {
        TestModel1 TestModelField = new TestModel1();
        TestModel1 TestModelProperty { get; set; } =  new TestModel1();
        TestModel1 TestModelMethod(out TestModel1 testModel)
        {
            testModel = new TestModel1();
            return testModel;
        }

        [Fact]
        public void TestModelLocal()
        {
            int RxAccountHandlerEvent = 0;
            int RxActionEvent1 = 0;
            int RxActionEvent2 = 0;
            int RxEventHandlerEvent1 = 0;
            int RxEventHandlerEvent2 = 0;

            var locaModel = new TestModel1();

            locaModel.RxAccountHandlerEvent().Select(t => 10).Subscribe(t => RxAccountHandlerEvent = t);
            locaModel.RxActionEvent1().Select(t => 10).Subscribe(t => RxActionEvent1 = t);
            locaModel.RxActionEvent2().Select(t => 10).Subscribe(t => RxActionEvent2 = t);
            locaModel.RxEventHandlerEvent1().Select(t => 10).Subscribe(t => RxEventHandlerEvent1 = t);
            locaModel.RxEventHandlerEvent2().Select(t => 10).Subscribe(t => RxEventHandlerEvent2 = t);

            locaModel.FireAccountHandlerEvent();
            locaModel.FireActionEvent1();
            locaModel.FireActionEvent2();
            locaModel.FireEventHandlerEvent1();
            locaModel.FireEventHandlerEvent2();
           
            Assert.Equal(10, RxAccountHandlerEvent);
            Assert.Equal(10, RxActionEvent1);
            Assert.Equal(10, RxActionEvent2);
            Assert.Equal(10, RxEventHandlerEvent1);
            Assert.Equal(10, RxEventHandlerEvent2);
        }

        [Fact]
        public void TestModelField1()
        {
            int RxAccountHandlerEvent = 0;
            int RxActionEvent1 = 0;
            int RxActionEvent2 = 0;
            int RxEventHandlerEvent1 = 0;
            int RxEventHandlerEvent2 = 0;

            TestModelField.RxAccountHandlerEvent().Select(t=>10).Subscribe(t=> RxAccountHandlerEvent = t);
            TestModelField.RxActionEvent1().Select(t => 10).Subscribe(t => RxActionEvent1 = t);
            TestModelField.RxActionEvent2().Select(t => 10).Subscribe(t => RxActionEvent2 = t);
            TestModelField.RxEventHandlerEvent1().Select(t => 10).Subscribe(t => RxEventHandlerEvent1 = t);
            TestModelField.RxEventHandlerEvent2().Select(t => 10).Subscribe(t => RxEventHandlerEvent2 = t);

            TestModelField.FireAccountHandlerEvent();
            TestModelField.FireActionEvent1();
            TestModelField.FireActionEvent2();
            TestModelField.FireEventHandlerEvent1();
            TestModelField.FireEventHandlerEvent2();

            Assert.Equal(10, RxAccountHandlerEvent);
            Assert.Equal(10, RxActionEvent1);
            Assert.Equal(10, RxActionEvent2);
            Assert.Equal(10, RxEventHandlerEvent1);
            Assert.Equal(10, RxEventHandlerEvent2);
        }

        [Fact]
        public void TestModelProperty1()
        {
            int RxAccountHandlerEvent = 0;
            int RxActionEvent1 = 0;
            int RxActionEvent2 = 0;
            int RxEventHandlerEvent1 = 0;
            int RxEventHandlerEvent2 = 0;

            TestModelProperty.RxAccountHandlerEvent().Select(t => 10).Subscribe(t => RxAccountHandlerEvent = t);
            TestModelProperty.RxActionEvent1().Select(t => 10).Subscribe(t => RxActionEvent1 = t);
            TestModelProperty.RxActionEvent2().Select(t => 10).Subscribe(t => RxActionEvent2 = t);
            TestModelProperty.RxEventHandlerEvent1().Select(t => 10).Subscribe(t => RxEventHandlerEvent1 = t);
            TestModelProperty.RxEventHandlerEvent2().Select(t => 10).Subscribe(t => RxEventHandlerEvent2 = t);

            TestModelProperty.FireAccountHandlerEvent();
            TestModelProperty.FireActionEvent1();
            TestModelProperty.FireActionEvent2();
            TestModelProperty.FireEventHandlerEvent1();
            TestModelProperty.FireEventHandlerEvent2();

            Assert.Equal(10, RxAccountHandlerEvent);
            Assert.Equal(10, RxActionEvent1);
            Assert.Equal(10, RxActionEvent2);
            Assert.Equal(10, RxEventHandlerEvent1);
            Assert.Equal(10, RxEventHandlerEvent2);
        }

        [Fact]
        public void TestModelMethod1()
        {
            int RxAccountHandlerEvent = 0;
            int RxActionEvent1 = 0;
            int RxActionEvent2 = 0;
            int RxEventHandlerEvent1 = 0;
            int RxEventHandlerEvent2 = 0;

            TestModelMethod(out var RxAccountHandlerEventModel).RxAccountHandlerEvent().Select(t => 10).Subscribe(t => RxAccountHandlerEvent = t);
            TestModelMethod(out var RxActionEvent1Model).RxActionEvent1().Select(t => 10).Subscribe(t => RxActionEvent1 = t);
            TestModelMethod(out var RxActionEvent2Model).RxActionEvent2().Select(t => 10).Subscribe(t => RxActionEvent2 = t);
            TestModelMethod(out var RxEventHandlerEvent1Model).RxEventHandlerEvent1().Select(t => 10).Subscribe(t => RxEventHandlerEvent1 = t);
            TestModelMethod(out var RxEventHandlerEvent2Model).RxEventHandlerEvent2().Select(t => 10).Subscribe(t => RxEventHandlerEvent2 = t);

            RxAccountHandlerEventModel.FireAccountHandlerEvent();
            RxActionEvent1Model.FireActionEvent1();
            RxActionEvent2Model.FireActionEvent2();
            RxEventHandlerEvent1Model.FireEventHandlerEvent1();
            RxEventHandlerEvent2Model.FireEventHandlerEvent2();

            Assert.Equal(10, RxAccountHandlerEvent);
            Assert.Equal(10, RxActionEvent1);
            Assert.Equal(10, RxActionEvent2);
            Assert.Equal(10, RxEventHandlerEvent1);
            Assert.Equal(10, RxEventHandlerEvent2);
        }
    }
}
