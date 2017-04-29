namespace Flinter
{
    public class Profile
    {
        public enum Gender { Man, Woman }
        public enum EyeColor { Blue, Green, Red, Brown }
        public enum HairColor { White, Blond, Brown, Black, Grey }
        public enum HeightCategory { VeryShort, Short, Medium, Tall, VeryTall, Unknown }

        private Gender _gender;
        private EyeColor _eyeColor;
        private HairColor _hairColor;
        private HeightCategory _heightCategory;

        public Profile(Gender gender, EyeColor eyeColor, HairColor hairColor, HeightCategory heightCategory)
        {
            _gender = gender;
            _eyeColor = eyeColor;
            _hairColor = hairColor;
            _heightCategory = heightCategory;
        }

        public string Description
        {
            get
            {
                string description = "You got a " + _gender;

                description = description + ", with " + _eyeColor + " eyes";
                description = description + ", " + _hairColor + " hair";
                description = description + ", who is " + _heightCategory;

                return description;
            }
        }
    }
}