Feature: Moving the Pawn.
	In order to play chess
	As a Player
	I want to move the Pawn legally.

Scenario: White Pawn moves one space from home row

Given I have an empty board
  And I have a White Pawn at B2
 When I move B2 to B3
 Then I see the message: 'Pawn to B3'
  And I have a White Pawn at B3
  And I do not have a piece at B2

Scenario: Black Pawn moves two spaces from home row

Given I have an empty board
  And I have a Black Pawn at E7
 When I move E7 to E5
 Then I see the message: 'Pawn to E5'
  And I have a Black Pawn at E5
  And I do not have a piece at E7
  
  
Scenario: White Pawn tries to move three space from home row

Given I have an empty board
  And I have a White Pawn at D2
 When I move D2 to D5
 Then I see the message: 'Illegal Move'
 
Scenario: White Pawn tries to move backwards from home row

Given I have an empty board
  And I have a White Pawn at C2
 When I move C2 to C1
 Then I see the message: 'Illegal Move'
 
 
 Scenario: White Pawn tries to move 2 squares when not on home row

Given I have an empty board
  And I have a White Pawn at C3
 When I move C3 to C5
 Then I see the message: 'Illegal Move'
 
 Scenario: Black Pawn tries to move backwards from home row

Given I have an empty board
  And I have a Black Pawn at C7
 When I move C7 to C8
 Then I see the message: 'Illegal Move'
 
Scenario: Black Pawn tries to move diagonally without taking a piece

Given I have an empty board
  And I have a Black Pawn at C7
 When I move C7 to D6
 Then I see the message: 'Illegal Move'
 
 Scenario: Black Pawn takes a White Pawn

Given I have an empty board
  And I have a Black Pawn at C7
  And I have a White Pawn at D6
 When I move C7 to D6
 Then I see the message: 'Pawn to D6. Pawn takes Pawn'
 
 