﻿namespace ImgGen
{
    using System;

    [Flags]
    public enum Type : int
    {
        TYPE_MONSTER = 0x1,
        TYPE_SPELL = 0x2,
        TYPE_TRAP = 0x4,
        TYPE_NORMAL = 0x10,
        TYPE_EFFECT = 0x20,
        TYPE_FUSION = 0x40,
        TYPE_RITUAL = 0x80,
        TYPE_TRAPMONSTER = 0x100,
        TYPE_SPIRIT = 0x200,
        TYPE_UNION = 0x400,
        TYPE_DUAL = 0x800,
        TYPE_TUNER = 0x1000,
        TYPE_SYNCHRO = 0x2000,
        TYPE_TOKEN = 0x4000,
        TYPE_QUICKPLAY = 0x10000,
        TYPE_CONTINUOUS = 0x20000,
        TYPE_EQUIP = 0x40000,
        TYPE_FIELD = 0x80000,
        TYPE_COUNTER = 0x100000,
        TYPE_FLIP = 0x200000,
        TYPE_TOON = 0x400000,
        TYPE_XYZ = 0x800000,
        TYPE_PENDULUM = 0x1000000,
        TYPE_SPSUMMON = 0x2000000,
        TYPE_LINK = 0x4000000
    }
}

