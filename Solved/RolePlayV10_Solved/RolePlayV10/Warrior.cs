using System;

namespace RolePlayV10
{
    public class Warrior
    {
        // Instance fields
        private string _name;
        private int _level; // Added

        // Constructor
        public Warrior(string name)
        {
            _name = name;
            _level = 1; // Added
        }

        // Properties
        public string Name
        {
            get { return _name; }
        }

        public int Level // Added
        {
            get { return _level; }
        }

        // Methods (just one here so far...)
        public void LevelUp() // Added
        {
            _level = _level + 1;
        }
    }
}