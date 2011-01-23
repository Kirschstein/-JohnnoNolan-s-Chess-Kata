// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.5.0.0
//      Runtime Version:2.0.50727.3615
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace ChessKata
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Moving the Pawn.")]
    public partial class MovingThePawn_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PawnMoves.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Moving the Pawn.", "In order to play chess\r\nAs a Player\r\nI want to move the Pawn legally.", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("White Pawn moves one space from home row")]
        public virtual void WhitePawnMovesOneSpaceFromHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("White Pawn moves one space from home row", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 8
testRunner.Given("I have an empty board");
#line 9
  testRunner.And("I have a White Pawn at B2");
#line 10
 testRunner.When("I move B2 to B3");
#line 11
 testRunner.Then("I see the message: \'Pawn to B3\'");
#line 12
  testRunner.And("I have a White Pawn at B3");
#line 13
  testRunner.And("I do not have a piece at B2");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Black Pawn moves two spaces from home row")]
        public virtual void BlackPawnMovesTwoSpacesFromHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Black Pawn moves two spaces from home row", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 17
testRunner.Given("I have an empty board");
#line 18
  testRunner.And("I have a Black Pawn at E7");
#line 19
 testRunner.When("I move E7 to E5");
#line 20
 testRunner.Then("I see the message: \'Pawn to E5\'");
#line 21
  testRunner.And("I have a Black Pawn at E5");
#line 22
  testRunner.And("I do not have a piece at E7");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("White Pawn tries to move three space from home row")]
        public virtual void WhitePawnTriesToMoveThreeSpaceFromHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("White Pawn tries to move three space from home row", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 27
testRunner.Given("I have an empty board");
#line 28
  testRunner.And("I have a White Pawn at D2");
#line 29
 testRunner.When("I move D2 to D5");
#line 30
 testRunner.Then("I see the message: \'Illegal Move\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("White Pawn tries to move backwards from home row")]
        public virtual void WhitePawnTriesToMoveBackwardsFromHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("White Pawn tries to move backwards from home row", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 34
testRunner.Given("I have an empty board");
#line 35
  testRunner.And("I have a White Pawn at C2");
#line 36
 testRunner.When("I move C2 to C1");
#line 37
 testRunner.Then("I see the message: \'Illegal Move\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("White Pawn tries to move 2 squares when not on home row")]
        public virtual void WhitePawnTriesToMove2SquaresWhenNotOnHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("White Pawn tries to move 2 squares when not on home row", ((string[])(null)));
#line 40
 this.ScenarioSetup(scenarioInfo);
#line 42
testRunner.Given("I have an empty board");
#line 43
  testRunner.And("I have a White Pawn at C3");
#line 44
 testRunner.When("I move C3 to C5");
#line 45
 testRunner.Then("I see the message: \'Illegal Move\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Black Pawn tries to move backwards from home row")]
        public virtual void BlackPawnTriesToMoveBackwardsFromHomeRow()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Black Pawn tries to move backwards from home row", ((string[])(null)));
#line 47
 this.ScenarioSetup(scenarioInfo);
#line 49
testRunner.Given("I have an empty board");
#line 50
  testRunner.And("I have a Black Pawn at C7");
#line 51
 testRunner.When("I move C7 to C8");
#line 52
 testRunner.Then("I see the message: \'Illegal Move\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Black Pawn tries to move diagonally without taking a piece")]
        public virtual void BlackPawnTriesToMoveDiagonallyWithoutTakingAPiece()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Black Pawn tries to move diagonally without taking a piece", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 56
testRunner.Given("I have an empty board");
#line 57
  testRunner.And("I have a Black Pawn at C7");
#line 58
 testRunner.When("I move C7 to D6");
#line 59
 testRunner.Then("I see the message: \'Illegal Move\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Black Pawn takes a White Pawn")]
        public virtual void BlackPawnTakesAWhitePawn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Black Pawn takes a White Pawn", ((string[])(null)));
#line 61
 this.ScenarioSetup(scenarioInfo);
#line 63
testRunner.Given("I have an empty board");
#line 64
  testRunner.And("I have a Black Pawn at C7");
#line 65
  testRunner.And("I have a White Pawn at D6");
#line 66
 testRunner.When("I move C7 to D6");
#line 67
 testRunner.Then("I see the message: \'Pawn to D6. Pawn takes Pawn\'");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion