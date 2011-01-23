Feature: Boundaries of the board.
	In order to obey the rules of Chess
	As a Move Taker
	I want to be prevented from entering moves outside the boundary of the board.

Scenario: Pawn tries to move off board

Given I have an empty board
  And I have a White Pawn at A8
 When I move A8 to A9
 Then I see the message: 'Illegal Move'
 
 Scenario: Knight tries to move off board

Given I have an empty board
  And I have a Black Knight at G8
 When I move G8 to I7
 Then I see the message: 'Illegal Move'
 
Scenario: Pawn moves legally

Given I have an empty board
  And I have a White Pawn at A7
 When I move A7 to A8
 Then I see the message: 'Pawn to A8'
  And I have a White Pawn at A8
  And I do not have a piece at A7
  
Scenario: Knight moves legally

Given I have an empty board
  And I have a Black Knight at G8
 When I move G8 to H6
 Then I see the message: 'Knight to H6'
  And I have a Black Knight at H6
  And I do not have a piece at G8