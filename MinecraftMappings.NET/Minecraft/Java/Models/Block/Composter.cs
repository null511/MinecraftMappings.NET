using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Composter : JavaBlockModel
    {
        public Composter() : base("Composter")
        {
            AddVersion("composter", "1.14")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("top", "block/composter_top")
                .AddTexture("bottom", "block/composter_bottom")
                .AddTexture("side", "block/composter_side")
                .AddTexture("inside", "block/composter_bottom")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 2f, 16f);
                    element.FaceUp = new ModelFace("#inside");
                    element.FaceDown = new ModelFace("#bottom");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(2f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 0f);
                    element.To = new Vector3(14f, 16f, 2f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 0f, 14f);
                    element.To = new Vector3(14f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                });
        }
    }
}
