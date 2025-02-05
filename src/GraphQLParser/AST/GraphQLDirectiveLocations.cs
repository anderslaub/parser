namespace GraphQLParser.AST;

/// <summary>
/// AST node for <see cref="ASTNodeKind.DirectiveLocations"/>.
/// </summary>
public class GraphQLDirectiveLocations : ASTNode // no ASTListNode<DirectiveLocation> since DirectiveLocation is enum
{
    /// <inheritdoc/>
    public override ASTNodeKind Kind => ASTNodeKind.DirectiveLocations;

    /// <summary>
    /// A list of locations representing the valid locations where directive may be placed.
    /// </summary>
    public List<DirectiveLocation> Items { get; set; } = null!;
}

internal sealed class GraphQLDirectiveLocationsWithLocation : GraphQLDirectiveLocations
{
    private GraphQLLocation _location;

    public override GraphQLLocation Location
    {
        get => _location;
        set => _location = value;
    }
}

internal sealed class GraphQLDirectiveLocationsWithComment : GraphQLDirectiveLocations
{
    private List<GraphQLComment>? _comments;

    public override List<GraphQLComment>? Comments
    {
        get => _comments;
        set => _comments = value;
    }
}

internal sealed class GraphQLDirectiveLocationsFull : GraphQLDirectiveLocations
{
    private GraphQLLocation _location;
    private List<GraphQLComment>? _comments;

    public override GraphQLLocation Location
    {
        get => _location;
        set => _location = value;
    }

    public override List<GraphQLComment>? Comments
    {
        get => _comments;
        set => _comments = value;
    }
}
