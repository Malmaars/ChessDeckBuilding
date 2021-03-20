using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Piece
{
    public bool Attack(int PosX, int PosY, int TarX, int TarY)
    {
        return Move(PosX, PosY, TarX, TarY);
    }

    public bool Move(int PosX, int PosY, int TarX, int TarY)
    {
        if(PosX == TarX)
        {
            return true;
        }

        if (PosY == TarY)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
