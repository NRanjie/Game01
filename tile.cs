 using System;


class Tile

{
  public string tileName;
  public char tileSymbol;
  public bool tileWalkable;

  public Tile(string name, char symbol, bool walkable)
  {
    tileName = name;
    tileSymbol = symbol;
    tileWalkable = walkable;
  }

} 
