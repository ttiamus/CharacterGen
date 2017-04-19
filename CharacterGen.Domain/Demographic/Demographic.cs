namespace CharacterGen.Domain.Demographic
{
    public class Demographic : IDemographic
    {
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public int Height { get; set; }         //In inches
        public int Weight { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public void UpdatePlayerName(string playerName)
        {
            this.PlayerName = playerName;
        }

        public void UpdateCharacterName(string characterName)
        {
            this.CharacterName = characterName;
        }

        public void UpdateHeight(int height)
        {
            this.Height = height;
        }

        public void UpdateWeight(int weight)
        {
            this.Weight = weight;
        }

        public void UpdateEyes(string eyes)
        {
            this.Eyes = eyes;
        }

        public void UpdateSkin(string skin)
        {
            this.Skin = skin;
        }

        public void UpdateHair(string hair)
        {
            this.Hair = hair;
        }
    }
}