using System.Collections.Generic;
using System.Linq;

// <command list> ::= <command>* end
public class CommandListNode : Node
{
    private List<CommandNode> list = new List<CommandNode>();

    public override void Parse(Context context)
    {
        while (true)
        {
            if (context.CurrentToken() == null)
                throw new ParseException("Missing 'end'");

            if (context.CurrentToken().Equals("end"))
            {
                context.SkipToken("end");
                break;
            }

            CommandNode commnadNode = new CommandNode();
            commnadNode.Parse(context);
            list.Add(commnadNode);
        }
    }

    public override string ToString()
    {
        return "[" + string.Join(", ", list.Select(node => node.ToString()).ToList()) + "]";
    }
}
