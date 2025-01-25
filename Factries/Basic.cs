using JumpKing.API;
using JumpKing.Level;
using JumpKing.Level.Sampler;
using JumpKing.Workshop;
using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace JumpKing_UpsideDownBlocks.Factries
{
    internal class Basic : IBlockFactory
    {
        private readonly HashSet<Color> supportedBlockCodes = new HashSet<Color> { Constants.ColorCodes.CODE_UPSIDE_DOWN };
        private readonly ArrayList solidBlocksCode = new ArrayList { };
        public bool CanMakeBlock(Color blockCode, Level level)
        {
            return supportedBlockCodes.Contains(blockCode);
        }

        public bool IsSolidBlock(Color blockCode)
        {
            return solidBlocksCode.Contains(blockCode);
        }

        public IBlock GetBlock(Color blockCode, Rectangle blockRect, JumpKing.Workshop.Level level, LevelTexture textureSrc, int currentScreen, int x, int y)
        {
            switch (blockCode)
            {
                case var _ when blockCode == Constants.ColorCodes.CODE_UPSIDE_DOWN:
                    return new Blocks.UpsideDown(blockRect);
                default:
                    throw new InvalidOperationException($"{typeof(Basic).Name} is unable to create a block of Color code ({blockCode.R}, {blockCode.G}, {blockCode.B})");
            }
        }
    }
}
