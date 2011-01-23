Feature: Moving the Knight.
	In order to play chess
	As a Player
	I want to move the Knight legally.

Scenario: Moving the knight legally

Given I have an empty board
  And I have a Black Knight at A7
 When I move A7 to B5
 Then I see the message: 'Knight to B5'
  And I have a Black Knight at B5
  And I do not have a piece at A7
  
Scenario: Moving the knight illegally

Given I have an empty board
  And I have a Black Knight at A7
 When I move A7 to C4
 Then I see the message: 'Illegal Move'
  And I have a Black Knight at A7
  
Scenario: Moving the knight illegally, 3 squares vertically

Given I have an empty board
  And I have a Black Knight at A7
 When I move A7 to A4
 Then I see the message: 'Illegal Move'
  And I have a Black Knight at A7
  
  
Scenario: Moving the knight illegally, moving onto piece of same colour

Given I have an empty board
  And I have a Black Knight at A7
  And I have a Black Pawn at B5
 When I move A7 to B5
 Then I see the message: 'Illegal Move'
  And I have a Black Knight at A7
  And I have a Black Pawn at B5