﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MolarFlowTests : MolarFlowTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        protected override double CentimolesPerDayInOneMolePerSecond => 100d * 60d * 60d * 24d;
        protected override double CentimolesPerSecondInOneMolePerSecond => 100d;
        protected override double DecamolesPerDayInOneMolePerSecond => 0.1 * 60d * 60d * 24d;
        protected override double DecamolesPerSecondInOneMolePerSecond => 0.1;
        protected override double DecimolesPerDayInOneMolePerSecond => 10d * 60d * 60d * 24d;
        protected override double DecimolesPerSecondInOneMolePerSecond => 10d;
        protected override double HectomolesPerDayInOneMolePerSecond => 0.01 * 60d * 60d * 24d;
        protected override double HectomolesPerSecondInOneMolePerSecond => 0.01;
        protected override double KilomolesPerDayInOneMolePerSecond => 0.001 * 60d * 60d * 24d;
        protected override double KilomolesPerHourInOneMolePerSecond => 0.001 * 60d * 60d;
        protected override double KilomolesPerMinuteInOneMolePerSecond => 0.001 * 60d;
        protected override double KilomolesPerSecondInOneMolePerSecond => 0.001;
        protected override double MegamolesPerDayInOneMolePerSecond => 0.000_001 * 60d * 60d * 24d;
        protected override double MicromolesPerDayInOneMolePerSecond => 1_000_000d * 60d * 60d * 24d;
        protected override double MicromolesPerSecondInOneMolePerSecond => 1_000_000d;
        protected override double MillimolesPerDayInOneMolePerSecond => 1000d * 60d * 60d * 24d;
        protected override double MillimolesPerSecondInOneMolePerSecond => 1000d;
        protected override double MolesPerDayInOneMolePerSecond => 1d * 60d * 60d * 24d;
        protected override double MolesPerHourInOneMolePerSecond => 1d * 60d * 60d;
        protected override double MolesPerSecondInOneMolePerSecond => 1d;
        protected override double NanomolesPerDayInOneMolePerSecond => 1_000_000_000d * 60d * 60d * 24d;
        protected override double NanomolesPerSecondInOneMolePerSecond => 1_000_000_000d;

        [Fact]
        public void DurationTimesMolarFlowEqualsAmountOfSubstance()
        {
            AmountOfSubstance amountOfSubstance = Duration.FromSeconds(4.0) * MolarFlow.FromMolesPerSecond(20.0);
            Assert.Equal(amountOfSubstance, AmountOfSubstance.FromMoles(80.0));
        }

        [Fact]
        public void MolarFlowTimesDurationEqualsAmountOfSubstance()
        {
            AmountOfSubstance amountOfSubstance = MolarFlow.FromMolesPerSecond(20.0) * Duration.FromSeconds(4.0);
            Assert.Equal(amountOfSubstance, AmountOfSubstance.FromMoles(80.0));
        }

        [Fact]
        public void MolarFlowTimesTimeSpanEqualsAmountOfSubstance()
        {
            AmountOfSubstance amountOfSubstance = MolarFlow.FromMolesPerSecond(20.0) * TimeSpan.FromSeconds(4.0);
            Assert.Equal(amountOfSubstance, AmountOfSubstance.FromMoles(80.0));
        }

        [Fact]
        public void TimeSpanTimesMolarFlowEqualsAmountOfSubstance()
        {
            AmountOfSubstance amountOfSubstance = TimeSpan.FromSeconds(4.0) * MolarFlow.FromMolesPerSecond(20.0);
            Assert.Equal(amountOfSubstance, AmountOfSubstance.FromMoles(80.0));
        }
    }
}
