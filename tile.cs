 using System;


class Tile
{
    public string _tileName { get; }
    public char _tileSymbol { get; }
    public bool _tileWalkable { get; }

    public Tile(string name, char symbol, bool walkable)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Symbol = symbol;
        Walkable = walkable;
    }

    public override string ToString() => $"{Name} ({Symbol}) Walkable={Walkable}";

  }

} 
