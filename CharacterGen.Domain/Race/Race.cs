﻿using System;
using System.Collections;
using System.Collections.Generic;
using CharacterGen.Domain.AbilityScore;
using CharacterGen.Domain.Enums;
using CharacterGen.Domain.Languages;
using MongoDB.Bson;

namespace CharacterGen.Domain.Race
{
    public class Race : IRace
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string SubraceName { get; set; }
        public string SubraceDescription { get; set; }
        public AbilityScores AbilityScoreIncreases { get; set; }
        public int AverageAge { get; set; }
        public Alignment SuggestedAlignment { get; set; }
        public int Speed { get; set; } //in feet
        public IEnumerable<Language> Languages { get; set; }

        public IEnumerable<string> RacialAbilities { get; set; }

        //TODO: Find out how to handle dynamic abilities
        //public IEnumerable<RacialAbility> RacialAbilities { get; set; }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public void UpdateSubraceName(string subraceName)
        {
            this.SubraceName = subraceName;
        }

        public void UpdateSubraceDescription(string subraceDescription)
        {
            this.SubraceDescription = subraceDescription;
        }

        public void UpdateAbilityScoreIncreases(AbilityScores abilityScores)
        {
            this.AbilityScoreIncreases.UpdateAbilityScores(abilityScores);
        }

        public void UpdateAverageAge(int averageAge)
        {
            this.AverageAge = averageAge;
        }

        public void UpdateSuggestedAlignment(int intAlignment)
        {
            Alignment alignment;
            if (Enum.TryParse(intAlignment.ToString(), out alignment))
            {
                this.SuggestedAlignment = alignment;
            }
            else
            {
                //TODO: Log error trying to parse alignment
            }
        }

        public void UpdateSuggestedAlignment(Alignment alignment)
        {
            this.SuggestedAlignment = alignment;
        }

        public void UpdateSpeed(int speed)
        {
            this.Speed = speed;
        }

        public void UpdateLanguages(IEnumerable<Language> languages)
        {
            this.Languages = languages;
        }

        public void UpdateRacialAbilities(IEnumerable<string> racialAbilities)
        {
            this.RacialAbilities = racialAbilities;
        }
    }
}