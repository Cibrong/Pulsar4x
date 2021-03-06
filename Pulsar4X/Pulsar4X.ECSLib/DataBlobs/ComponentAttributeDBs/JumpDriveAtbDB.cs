﻿namespace Pulsar4X.ECSLib
{
    public class JumpDriveAtbDB : BaseDataBlob
    {
        public int MaxShipSize { get; internal set; }
        public int MaxSquadronSize { get; internal set; }
        /// <summary>
        /// Max distance from JP when arriving. Measured in KM
        /// </summary>
        public int MaxDisplacement { get; internal set; }

        public override object Clone()
        {
            return new JumpDriveAtbDB
            {
                MaxShipSize = MaxShipSize,
                MaxSquadronSize = MaxSquadronSize,
                MaxDisplacement = MaxDisplacement,
                OwningEntity = OwningEntity
            };
        }
    }
}
