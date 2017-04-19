namespace CharacterGen.Domain.Demographic
{
    public interface IDemographic
    {
        void UpdatePlayerName(string playerName);
        void UpdateCharacterName(string characterName);
        void UpdateHeight(int height);
        void UpdateWeight(int weight);
        void UpdateEyes(string eyes);
        void UpdateSkin(string skin);
        void UpdateHair(string hair);
    }
}