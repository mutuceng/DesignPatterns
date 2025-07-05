using TemplateMethod.AbstractClass;
using TemplateMethod.ConcreteClasses;

CallCenterProcessor centerA = new CallCenterA();
centerA.ProcessCallRecords("CALL001");

CallCenterProcessor centerB = new CallCenterB();
centerB.ProcessCallRecords("CALL002");

CallCenterProcessor centerC = new CallCenterC();
centerC.ProcessCallRecords("CALL003");