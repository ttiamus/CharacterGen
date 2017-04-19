namespace CharacterGen.Domain.Currencies
{
    public class Currency : ICurrency
    {
        private int Copper { get; set; }
        private int Silver { get; set; }
        private int Electrum { get; set; }
        private int Gold { get; set; }
        private int Platinum { get; set; }

        public void UpdateCopper(int copper)
        {
            this.Copper = copper;
        }

        public void UpdateSilver(int silver)
        {
            this.Silver = silver;
        }

        public void UpdateElectrum(int electrum)
        {
            this.Electrum = electrum;
        }

        public void UpdateGold(int gold)
        {
            this.Gold = gold;
        }

        public void UpdatePlatinum(int platinum)
        {
            this.Platinum = platinum;
        }
    }
}