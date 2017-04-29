using System;

namespace RolePlayV10
{
    public class Warrior
    {
        private string _name;
        private int _level;
        private int _hitPoints;

        public string Name
        {
            get { return _name; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int HitPoints
        {
            get { return _hitPoints;}
        }

        public bool Dead
        {
            get { return (_hitPoints < 0); }
        }

        public Warrior(string name, int hitPoints)
        {
            _name = name;
            _level = 1;
            _hitPoints = hitPoints;
        }

        public void LevelUp()
        {
            _level = _level + 1;
        }

        public void DecreaseHitPoints(int points)
        {
            _hitPoints = _hitPoints - points;
        }
    }
}