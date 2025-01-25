using EntityComponent;
using JumpKing.Level;
using JumpKing.Mods;
using JumpKing.Player;

namespace JumpKing_UpsideDownBlocks
{
    [JumpKingMod("YutaGoto.JumpKing_UpsideDownBlocks")]
    public static class ModEntry
    {
        /// <summary>
        /// Called by Jump King before the level loads
        /// </summary>
        [BeforeLevelLoad]
        public static void BeforeLevelLoad()
        {
            LevelManager.RegisterBlockFactory(new Factries.Basic());
            UpsideDownCore.Controller.Reset();
        }

        /// <summary>
        /// Called by Jump King when the Level Starts
        /// </summary>
        [OnLevelStart]
        public static void OnLevelStart()
        {
            PlayerEntity player = EntityManager.instance.Find<PlayerEntity>();

            if (player != null)
            {
                player.m_body.RegisterBlockBehaviour<Blocks.UpsideDown>(new Behaviors.UpsideDown());
            }
        }
    }
}
