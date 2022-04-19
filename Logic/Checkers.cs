﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class Checkers
    {
        short m_Row;
        short m_Col;
        bool isKing = false;

        public int Row
        {
            get
            {
                return m_Row;
            }
            set
            {
                m_Row = Convert.ToInt16(value);
            }
        }
        public int Col
        {
            get
            {
                return m_Col;
            }
            set
            {
                m_Col = Convert.ToInt16(value);
            }
        }

        public void MoveChecker(string i_COLrow)   // Assuming that validation was checked by GameRules and only next position was given.
        {
            short col = -1 , row = -1;
            Engine.TranslateCharPositionToIndices(i_COLrow, ref col, ref  row);
            m_Row = (row != -1) ? Convert.ToInt16(row) : m_Row;
            m_Col = (col != -1) ? Convert.ToInt16(col) : m_Col;
        }
    }
}
