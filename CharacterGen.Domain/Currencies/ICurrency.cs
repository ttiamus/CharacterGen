namespace CharacterGen.Domain.Currencies
{
    public interface ICurrency
    {
        void UpdateCopper(int copper);
        void UpdateSilver(int silver);
        void UpdateElectrum(int electrum);
        void UpdateGold(int gold);
        void UpdatePlatinum(int platinum);
    }
}