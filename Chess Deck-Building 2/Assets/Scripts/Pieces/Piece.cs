using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public interface Piece
{
    //int value { get; set; }
    //GameObject visual voor zwart en wit
    bool Attack(int PosX, int PosY, int TarX, int TarY);
    bool Move(int PosX, int PosY, int TarX, int TarY);
}
