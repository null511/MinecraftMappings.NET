using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cube_ColumnHorizontal : JavaBlockModel
    {
        public Cube_ColumnHorizontal() : base("Cube Column, Horizontal")
        {
            AddVersion("cube_column_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("up", "#end")
                .AddTexture("down", "#end")
                .AddTexture("north", "#side")
                .AddTexture("south", "#side")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#up", UVFull) {
                        Rotation = 180,
                    };
                    element.FaceDown = new ModelFace("#down", UVFull);
                    element.FaceNorth = new ModelFace("#north", UVFull);
                    element.FaceSouth = new ModelFace("#south", UVFull);
                    element.FaceWest = new ModelFace("#west", UVFull);
                    element.FaceEast = new ModelFace("#east", UVFull);
                });
        }
    }
}
