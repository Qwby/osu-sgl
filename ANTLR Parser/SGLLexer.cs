// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g 2011-05-08 18:57:08

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class SGLLexer : Lexer {
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int SGLIDDigit = 11;
    public const int EOF = -1;
    public const int Identifier = 4;
    public const int T__19 = 19;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int String = 7;
    public const int COMMENT = 16;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int HEX_DIGIT = 14;
    public const int Float = 6;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 15;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 12;
    public const int Boolean = 8;
    public const int Letter = 10;
    public const int EscapeSequence = 9;
    public const int OctalEscape = 13;
    public const int Integer = 5;

    // delegates
    // delegators

    public SGLLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SGLLexer(ICharStream input)
		: this(input, null) {
    }
    public SGLLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g";} 
    }

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:7:7: ( ';' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:7:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:8:7: ( '=' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:8:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:9:7: ( 'boolean' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:9:9: 'boolean'
            {
            	Match("boolean"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:10:7: ( 'string' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:10:9: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:11:7: ( 'int' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:11:9: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:12:7: ( 'float' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:12:9: 'float'
            {
            	Match("float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:13:7: ( 'Object' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:13:9: 'Object'
            {
            	Match("Object"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:14:7: ( 'Sprite' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:14:9: 'Sprite'
            {
            	Match("Sprite"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:15:7: ( 'Animation' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:15:9: 'Animation'
            {
            	Match("Animation"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:16:7: ( '?' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:16:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:17:7: ( ':' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:17:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:18:7: ( '||' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:18:9: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:19:7: ( '&&' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:19:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:20:7: ( '==' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:20:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:21:7: ( '!=' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:21:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:22:7: ( '<' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:22:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:23:7: ( '>' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:23:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:24:7: ( '<=' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:24:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:25:7: ( '>=' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:25:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:26:7: ( '+' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:26:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:27:7: ( '-' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:27:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:28:7: ( '*' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:28:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:29:7: ( '/' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:29:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:30:7: ( '%' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:30:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:31:7: ( '++' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:31:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:32:7: ( '--' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:32:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:33:7: ( '!' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:33:9: '!'
            {
            	Match('!'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:34:7: ( '(' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:34:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:35:7: ( ')' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:35:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:36:7: ( '.' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:36:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:37:7: ( ',' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:37:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:38:7: ( 'null' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:38:9: 'null'
            {
            	Match("null"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "Integer"
    public void mInteger() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Integer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:196:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:196:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:196:7: ( '0' .. '9' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:196:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Integer"

    // $ANTLR start "Float"
    public void mFloat() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Float;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt6 = 3;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:9: ( '0' .. '9' )+
                    	int cnt2 = 0;
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt2 >= 1 ) goto loop2;
                    		            EarlyExitException eee2 =
                    		                new EarlyExitException(2, input);
                    		            throw eee2;
                    	    }
                    	    cnt2++;
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	Match('.'); 
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:200:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:201:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:201:13: ( '0' .. '9' )+
                    	int cnt4 = 0;
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:201:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt4 >= 1 ) goto loop4;
                    		            EarlyExitException eee4 =
                    		                new EarlyExitException(4, input);
                    		            throw eee4;
                    	    }
                    	    cnt4++;
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:202:9: ( '0' .. '9' )+
                    {
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:202:9: ( '0' .. '9' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:202:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Float"

    // $ANTLR start "String"
    public void mString() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = String;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:206:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:206:8: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:206:12: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt7 = 3;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == '\\') )
            	    {
            	        alt7 = 1;
            	    }
            	    else if ( ((LA7_0 >= '\u0000' && LA7_0 <= '!') || (LA7_0 >= '#' && LA7_0 <= '[') || (LA7_0 >= ']' && LA7_0 <= '\uFFFF')) )
            	    {
            	        alt7 = 2;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:206:14: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:206:31: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "String"

    // $ANTLR start "Boolean"
    public void mBoolean() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Boolean;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:210:5: ( 'true' | 'false' )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 't') )
            {
                alt8 = 1;
            }
            else if ( (LA8_0 == 'f') )
            {
                alt8 = 2;
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:210:9: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:211:9: 'false'
                    {
                    	Match("false"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Boolean"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:217:5: ( Letter ( Letter | SGLIDDigit )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:217:9: Letter ( Letter | SGLIDDigit )*
            {
            	mLetter(); 
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:217:16: ( Letter | SGLIDDigit )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == '$' || (LA9_0 >= '0' && LA9_0 <= '9') || (LA9_0 >= 'A' && LA9_0 <= 'Z') || LA9_0 == '_' || (LA9_0 >= 'a' && LA9_0 <= 'z') || (LA9_0 >= '\u00C0' && LA9_0 <= '\u00D6') || (LA9_0 >= '\u00D8' && LA9_0 <= '\u00F6') || (LA9_0 >= '\u00F8' && LA9_0 <= '\u1FFF') || (LA9_0 >= '\u3040' && LA9_0 <= '\u318F') || (LA9_0 >= '\u3300' && LA9_0 <= '\u337F') || (LA9_0 >= '\u3400' && LA9_0 <= '\u3D2D') || (LA9_0 >= '\u4E00' && LA9_0 <= '\u9FFF') || (LA9_0 >= '\uF900' && LA9_0 <= '\uFAFF')) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
            			    {
            			    	if ( input.LA(1) == '$' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "Letter"
    public void mLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:229:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Letter"

    // $ANTLR start "SGLIDDigit"
    public void mSGLIDDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:246:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= '\u0660' && input.LA(1) <= '\u0669') || (input.LA(1) >= '\u06F0' && input.LA(1) <= '\u06F9') || (input.LA(1) >= '\u0966' && input.LA(1) <= '\u096F') || (input.LA(1) >= '\u09E6' && input.LA(1) <= '\u09EF') || (input.LA(1) >= '\u0A66' && input.LA(1) <= '\u0A6F') || (input.LA(1) >= '\u0AE6' && input.LA(1) <= '\u0AEF') || (input.LA(1) >= '\u0B66' && input.LA(1) <= '\u0B6F') || (input.LA(1) >= '\u0BE7' && input.LA(1) <= '\u0BEF') || (input.LA(1) >= '\u0C66' && input.LA(1) <= '\u0C6F') || (input.LA(1) >= '\u0CE6' && input.LA(1) <= '\u0CEF') || (input.LA(1) >= '\u0D66' && input.LA(1) <= '\u0D6F') || (input.LA(1) >= '\u0E50' && input.LA(1) <= '\u0E59') || (input.LA(1) >= '\u0ED0' && input.LA(1) <= '\u0ED9') || (input.LA(1) >= '\u1040' && input.LA(1) <= '\u1049') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "SGLIDDigit"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:267:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UnicodeEscape | OctalEscape )
            int alt10 = 3;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == '\\') )
            {
                switch ( input.LA(2) ) 
                {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                	{
                    alt10 = 1;
                    }
                    break;
                case 'u':
                	{
                    alt10 = 2;
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                	{
                    alt10 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d10s1 =
                	        new NoViableAltException("", 10, 1, input);

                	    throw nvae_d10s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:267:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    	Match('\\'); 
                    	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:268:9: UnicodeEscape
                    {
                    	mUnicodeEscape(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:269:9: OctalEscape
                    {
                    	mOctalEscape(); 

                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "OctalEscape"
    public void mOctalEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt11 = 3;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == '\\') )
            {
                int LA11_1 = input.LA(2);

                if ( ((LA11_1 >= '0' && LA11_1 <= '3')) )
                {
                    int LA11_2 = input.LA(3);

                    if ( ((LA11_2 >= '0' && LA11_2 <= '7')) )
                    {
                        int LA11_4 = input.LA(4);

                        if ( ((LA11_4 >= '0' && LA11_4 <= '7')) )
                        {
                            alt11 = 1;
                        }
                        else 
                        {
                            alt11 = 2;}
                    }
                    else 
                    {
                        alt11 = 3;}
                }
                else if ( ((LA11_1 >= '4' && LA11_1 <= '7')) )
                {
                    int LA11_3 = input.LA(3);

                    if ( ((LA11_3 >= '0' && LA11_3 <= '7')) )
                    {
                        alt11 = 2;
                    }
                    else 
                    {
                        alt11 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("", 11, 1, input);

                    throw nvae_d11s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:14: ( '0' .. '3' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:36: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:274:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:275:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:275:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:275:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:275:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:275:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:276:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:276:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:276:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OctalEscape"

    // $ANTLR start "UnicodeEscape"
    public void mUnicodeEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:281:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:281:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            	Match('\\'); 
            	Match('u'); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeEscape"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:285:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:285:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:291:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:291:8: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt15 = 2;
            int LA15_0 = input.LA(1);

            if ( (LA15_0 == '/') )
            {
                int LA15_1 = input.LA(2);

                if ( (LA15_1 == '/') )
                {
                    alt15 = 1;
                }
                else if ( (LA15_1 == '*') )
                {
                    alt15 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d15s1 =
                        new NoViableAltException("", 15, 1, input);

                    throw nvae_d15s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( ((LA12_0 >= '\u0000' && LA12_0 <= '\t') || (LA12_0 >= '\u000B' && LA12_0 <= '\f') || (LA12_0 >= '\u000E' && LA12_0 <= '\uFFFF')) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:14: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:28: ( '\\r' )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( (LA13_0 == '\r') )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:296:28: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:297:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:297:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == '*') )
                    	    {
                    	        int LA14_1 = input.LA(2);

                    	        if ( (LA14_1 == '/') )
                    	        {
                    	            alt14 = 2;
                    	        }
                    	        else if ( ((LA14_1 >= '\u0000' && LA14_1 <= '.') || (LA14_1 >= '0' && LA14_1 <= '\uFFFF')) )
                    	        {
                    	            alt14 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA14_0 >= '\u0000' && LA14_0 <= ')') || (LA14_0 >= '+' && LA14_0 <= '\uFFFF')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:297:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	Match("*/"); 

                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:8: ( T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | Integer | Float | String | Boolean | Identifier | WS | COMMENT )
        int alt16 = 39;
        alt16 = dfa16.Predict(input);
        switch (alt16) 
        {
            case 1 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:10: T__17
                {
                	mT__17(); 

                }
                break;
            case 2 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:16: T__18
                {
                	mT__18(); 

                }
                break;
            case 3 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:22: T__19
                {
                	mT__19(); 

                }
                break;
            case 4 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:28: T__20
                {
                	mT__20(); 

                }
                break;
            case 5 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:34: T__21
                {
                	mT__21(); 

                }
                break;
            case 6 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:40: T__22
                {
                	mT__22(); 

                }
                break;
            case 7 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:46: T__23
                {
                	mT__23(); 

                }
                break;
            case 8 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:52: T__24
                {
                	mT__24(); 

                }
                break;
            case 9 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:58: T__25
                {
                	mT__25(); 

                }
                break;
            case 10 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:64: T__26
                {
                	mT__26(); 

                }
                break;
            case 11 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:70: T__27
                {
                	mT__27(); 

                }
                break;
            case 12 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:76: T__28
                {
                	mT__28(); 

                }
                break;
            case 13 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:82: T__29
                {
                	mT__29(); 

                }
                break;
            case 14 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:88: T__30
                {
                	mT__30(); 

                }
                break;
            case 15 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:94: T__31
                {
                	mT__31(); 

                }
                break;
            case 16 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:100: T__32
                {
                	mT__32(); 

                }
                break;
            case 17 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:106: T__33
                {
                	mT__33(); 

                }
                break;
            case 18 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:112: T__34
                {
                	mT__34(); 

                }
                break;
            case 19 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:118: T__35
                {
                	mT__35(); 

                }
                break;
            case 20 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:124: T__36
                {
                	mT__36(); 

                }
                break;
            case 21 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:130: T__37
                {
                	mT__37(); 

                }
                break;
            case 22 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:136: T__38
                {
                	mT__38(); 

                }
                break;
            case 23 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:142: T__39
                {
                	mT__39(); 

                }
                break;
            case 24 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:148: T__40
                {
                	mT__40(); 

                }
                break;
            case 25 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:154: T__41
                {
                	mT__41(); 

                }
                break;
            case 26 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:160: T__42
                {
                	mT__42(); 

                }
                break;
            case 27 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:166: T__43
                {
                	mT__43(); 

                }
                break;
            case 28 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:172: T__44
                {
                	mT__44(); 

                }
                break;
            case 29 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:178: T__45
                {
                	mT__45(); 

                }
                break;
            case 30 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:184: T__46
                {
                	mT__46(); 

                }
                break;
            case 31 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:190: T__47
                {
                	mT__47(); 

                }
                break;
            case 32 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:196: T__48
                {
                	mT__48(); 

                }
                break;
            case 33 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:202: Integer
                {
                	mInteger(); 

                }
                break;
            case 34 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:210: Float
                {
                	mFloat(); 

                }
                break;
            case 35 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:216: String
                {
                	mString(); 

                }
                break;
            case 36 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:223: Boolean
                {
                	mBoolean(); 

                }
                break;
            case 37 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:231: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 38 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:242: WS
                {
                	mWS(); 

                }
                break;
            case 39 :
                // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:1:245: COMMENT
                {
                	mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
    protected DFA16 dfa16;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	    this.dfa16 = new DFA16(this);
	}

    const string DFA6_eotS =
        "\x01\uffff\x01\x03\x03\uffff";
    const string DFA6_eofS =
        "\x05\uffff";
    const string DFA6_minS =
        "\x02\x2e\x03\uffff";
    const string DFA6_maxS =
        "\x02\x39\x03\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA6_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "199:1: Float : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );"; }
        }

    }

    const string DFA16_eotS =
        "\x02\uffff\x01\x21\x07\x1e\x04\uffff\x01\x2b\x01\x2d\x01\x2f\x01"+
        "\x31\x01\x33\x01\uffff\x01\x35\x03\uffff\x01\x37\x01\uffff\x01\x1e"+
        "\x01\x39\x01\uffff\x01\x1e\x04\uffff\x08\x1e\x0e\uffff\x01\x1e\x01"+
        "\uffff\x03\x1e\x01\x47\x09\x1e\x01\uffff\x05\x1e\x01\x56\x01\x57"+
        "\x02\x1e\x01\x5a\x01\x57\x03\x1e\x02\uffff\x01\x1e\x01\x5f\x01\uffff"+
        "\x01\x60\x01\x61\x01\x1e\x01\x63\x03\uffff\x01\x1e\x01\uffff\x01"+
        "\x1e\x01\x66\x01\uffff";
    const string DFA16_eofS =
        "\x67\uffff";
    const string DFA16_minS =
        "\x01\x09\x01\uffff\x01\x3d\x01\x6f\x01\x74\x01\x6e\x01\x61\x01"+
        "\x62\x01\x70\x01\x6e\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff"+
        "\x01\x2a\x03\uffff\x01\x30\x01\uffff\x01\x75\x01\x2e\x01\uffff\x01"+
        "\x72\x04\uffff\x01\x6f\x01\x72\x01\x74\x01\x6f\x01\x6c\x01\x6a\x01"+
        "\x72\x01\x69\x0e\uffff\x01\x6c\x01\uffff\x01\x75\x01\x6c\x01\x69"+
        "\x01\x24\x01\x61\x01\x73\x01\x65\x01\x69\x01\x6d\x01\x6c\x02\x65"+
        "\x01\x6e\x01\uffff\x01\x74\x01\x65\x01\x63\x01\x74\x01\x61\x02\x24"+
        "\x01\x61\x01\x67\x02\x24\x01\x74\x01\x65\x01\x74\x02\uffff\x01\x6e"+
        "\x01\x24\x01\uffff\x02\x24\x01\x69\x01\x24\x03\uffff\x01\x6f\x01"+
        "\uffff\x01\x6e\x01\x24\x01\uffff";
    const string DFA16_maxS =
        "\x01\ufaff\x01\uffff\x01\x3d\x01\x6f\x01\x74\x01\x6e\x01\x6c\x01"+
        "\x62\x01\x70\x01\x6e\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff"+
        "\x01\x2f\x03\uffff\x01\x39\x01\uffff\x01\x75\x01\x39\x01\uffff\x01"+
        "\x72\x04\uffff\x01\x6f\x01\x72\x01\x74\x01\x6f\x01\x6c\x01\x6a\x01"+
        "\x72\x01\x69\x0e\uffff\x01\x6c\x01\uffff\x01\x75\x01\x6c\x01\x69"+
        "\x01\ufaff\x01\x61\x01\x73\x01\x65\x01\x69\x01\x6d\x01\x6c\x02\x65"+
        "\x01\x6e\x01\uffff\x01\x74\x01\x65\x01\x63\x01\x74\x01\x61\x02\ufaff"+
        "\x01\x61\x01\x67\x02\ufaff\x01\x74\x01\x65\x01\x74\x02\uffff\x01"+
        "\x6e\x01\ufaff\x01\uffff\x02\ufaff\x01\x69\x01\ufaff\x03\uffff\x01"+
        "\x6f\x01\uffff\x01\x6e\x01\ufaff\x01\uffff";
    const string DFA16_acceptS =
        "\x01\uffff\x01\x01\x08\uffff\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x05"+
        "\uffff\x01\x16\x01\uffff\x01\x18\x01\x1c\x01\x1d\x01\uffff\x01\x1f"+
        "\x02\uffff\x01\x23\x01\uffff\x01\x25\x01\x26\x01\x0e\x01\x02\x08"+
        "\uffff\x01\x0f\x01\x1b\x01\x12\x01\x10\x01\x13\x01\x11\x01\x19\x01"+
        "\x14\x01\x1a\x01\x15\x01\x27\x01\x17\x01\x22\x01\x1e\x01\uffff\x01"+
        "\x21\x0d\uffff\x01\x05\x0e\uffff\x01\x20\x01\x24\x02\uffff\x01\x06"+
        "\x04\uffff\x01\x04\x01\x07\x01\x08\x01\uffff\x01\x03\x02\uffff\x01"+
        "\x09";
    const string DFA16_specialS =
        "\x67\uffff}>";
    static readonly string[] DFA16_transitionS = {
            "\x02\x1f\x01\uffff\x02\x1f\x12\uffff\x01\x1f\x01\x0e\x01\x1c"+
            "\x01\uffff\x01\x1e\x01\x15\x01\x0d\x01\uffff\x01\x16\x01\x17"+
            "\x01\x13\x01\x11\x01\x19\x01\x12\x01\x18\x01\x14\x0a\x1b\x01"+
            "\x0b\x01\x01\x01\x0f\x01\x02\x01\x10\x01\x0a\x01\uffff\x01\x09"+
            "\x0d\x1e\x01\x07\x03\x1e\x01\x08\x07\x1e\x04\uffff\x01\x1e\x01"+
            "\uffff\x01\x1e\x01\x03\x03\x1e\x01\x06\x02\x1e\x01\x05\x04\x1e"+
            "\x01\x1a\x04\x1e\x01\x04\x01\x1d\x06\x1e\x01\uffff\x01\x0c\x43"+
            "\uffff\x17\x1e\x01\uffff\x1f\x1e\x01\uffff\u1f08\x1e\u1040\uffff"+
            "\u0150\x1e\u0170\uffff\u0080\x1e\u0080\uffff\u092e\x1e\u10d2"+
            "\uffff\u5200\x1e\u5900\uffff\u0200\x1e",
            "",
            "\x01\x20",
            "\x01\x22",
            "\x01\x23",
            "\x01\x24",
            "\x01\x26\x0a\uffff\x01\x25",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29",
            "",
            "",
            "",
            "",
            "\x01\x2a",
            "\x01\x2c",
            "\x01\x2e",
            "\x01\x30",
            "\x01\x32",
            "",
            "\x01\x34\x04\uffff\x01\x34",
            "",
            "",
            "",
            "\x0a\x36",
            "",
            "\x01\x38",
            "\x01\x36\x01\uffff\x0a\x1b",
            "",
            "\x01\x3a",
            "",
            "",
            "",
            "",
            "\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3e",
            "\x01\x3f",
            "\x01\x40",
            "\x01\x41",
            "\x01\x42",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x43",
            "",
            "\x01\x44",
            "\x01\x45",
            "\x01\x46",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x58",
            "\x01\x59",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x5b",
            "\x01\x5c",
            "\x01\x5d",
            "",
            "",
            "\x01\x5e",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "\x01\x62",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            "",
            "",
            "",
            "\x01\x64",
            "",
            "\x01\x65",
            "\x01\x1e\x0b\uffff\x0a\x1e\x07\uffff\x1a\x1e\x04\uffff\x01"+
            "\x1e\x01\uffff\x1a\x1e\x45\uffff\x17\x1e\x01\uffff\x1f\x1e\x01"+
            "\uffff\u1f08\x1e\u1040\uffff\u0150\x1e\u0170\uffff\u0080\x1e"+
            "\u0080\uffff\u092e\x1e\u10d2\uffff\u5200\x1e\u5900\uffff\u0200"+
            "\x1e",
            ""
    };

    static readonly short[] DFA16_eot = DFA.UnpackEncodedString(DFA16_eotS);
    static readonly short[] DFA16_eof = DFA.UnpackEncodedString(DFA16_eofS);
    static readonly char[] DFA16_min = DFA.UnpackEncodedStringToUnsignedChars(DFA16_minS);
    static readonly char[] DFA16_max = DFA.UnpackEncodedStringToUnsignedChars(DFA16_maxS);
    static readonly short[] DFA16_accept = DFA.UnpackEncodedString(DFA16_acceptS);
    static readonly short[] DFA16_special = DFA.UnpackEncodedString(DFA16_specialS);
    static readonly short[][] DFA16_transition = DFA.UnpackEncodedStringArray(DFA16_transitionS);

    protected class DFA16 : DFA
    {
        public DFA16(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 16;
            this.eot = DFA16_eot;
            this.eof = DFA16_eof;
            this.min = DFA16_min;
            this.max = DFA16_max;
            this.accept = DFA16_accept;
            this.special = DFA16_special;
            this.transition = DFA16_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | Integer | Float | String | Boolean | Identifier | WS | COMMENT );"; }
        }

    }

 
    
}
