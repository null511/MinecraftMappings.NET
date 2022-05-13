using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_CauldronLevel1 : JavaBlockModel
    {
        public Template_CauldronLevel1() : base("Template Cauldron, Level 1")
        {
            AddVersion("template_cauldron_level1", "1.0.0")
                .WithPath("models/block")
                .AddTexture("top", "block/cauldron_top")
                .AddTexture("bottom", "block/cauldron_bottom")
                .AddTexture("side", "block/cauldron_side")
                .AddTexture("inside", "block/cauldron_inner")
                .AddElement(element => {
                    element.From = new Vector3(0f, 3f, 0f);
                    element.To = new Vector3(2f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceDown = new ModelFace("#inside");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 2f);
                    element.To = new Vector3(14f, 4f, 14f);
                    element.FaceUp = new ModelFace("#inside");
                    element.FaceDown = new ModelFace("#inside");
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 3f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceDown = new ModelFace("#inside");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 0f);
                    element.To = new Vector3(14f, 16f, 2f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceDown = new ModelFace("#inside");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 14f);
                    element.To = new Vector3(14f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top");
                    element.FaceDown = new ModelFace("#inside");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(4f, 3f, 2f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 2f);
                    element.To = new Vector3(2f, 3f, 4f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, 0f, 0f);
                    element.To = new Vector3(16f, 3f, 2f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 2f);
                    element.To = new Vector3(16f, 3f, 4f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 14f);
                    element.To = new Vector3(4f, 3f, 16f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 12f);
                    element.To = new Vector3(2f, 3f, 14f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(12f, 0f, 14f);
                    element.To = new Vector3(16f, 3f, 16f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceSouth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(14f, 0f, 12f);
                    element.To = new Vector3(16f, 3f, 14f);
                    element.FaceDown = new ModelFace("#bottom");
                    element.FaceNorth = new ModelFace("#side");
                    element.FaceWest = new ModelFace("#side");
                    element.FaceEast = new ModelFace("#side");
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 4f, 2f);
                    element.To = new Vector3(14f, 9f, 14f);
                    element.FaceUp = new ModelFace("#content");
                });
        }
    }
}
