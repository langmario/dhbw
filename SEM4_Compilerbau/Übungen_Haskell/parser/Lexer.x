{
  module Lexer (toTokens, Token(..)) where
}
%wrapper "basic"

$digit = 0-9			-- digits
$alpha = [a-zA-Z]		-- alphabetic characters

tokens :-

  $white+				;
  [\+]					{ \s -> PlusOperator }
  [\-]					{ \s -> MinusOperator }
  [\*]          { \s -> MultOperator }
  [\/]          { \s -> DivOperator }
  $digit+		{ \s -> IntLiteral (read s) }

{
data Token =
  PlusOperator     |
  MinusOperator    |
  MultOperator     |
  DivOperator      |
	IntLiteral Int
	deriving (Eq,Show)

toTokens s = alexScanTokens s
}