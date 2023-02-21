// See https://aka.ms/new-console-template for more information

using StructuralExample.Alternative;
using StructuralExample.Structural;

AlternativeExample();

void AlternativeExample()
{
    var mediator = new ConcreteMediatorV2();
    //var colleagueA = new ColleagueA();
    //var colleagueB = new ColleagueB();
    //mediator.Register(colleagueA);
    //mediator.Register(colleagueB);
    var colleagueA = mediator.CreateColleague<ColleagueA>();
    var colleagueB = mediator.CreateColleague<ColleagueB>();

    colleagueA.Send("Hello, World! from (colleagueA)");
    colleagueB.Send("Hi, there! from (colleagueB)");
}

StructuralExample();

void StructuralExample()
{
    var mediator = new ConcreteMediator();
    var colleague1 = new Colleague1(mediator);
    var colleague2 = new Colleague2(mediator);
    mediator.Colleague1 = colleague1;
    mediator.Colleague2 = colleague2;

    colleague1.Send("Hello, World! from (colleague1)");
    colleague2.Send("Hi, there! from (colleague2)");
}