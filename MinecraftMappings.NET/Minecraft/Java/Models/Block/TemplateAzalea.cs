using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TemplateAzalea : JavaBlockModel
    {
        public TemplateAzalea() : base("Template Azalea")
        {
            AddVersion("template_azalea", "1.17")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("plant", "block/azalea_plant")
                .AddElement(element => {
                    element.From = new Vector3(0f, 16f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceDown = new ModelFace("#top", UVMap(0f, 16f, 16f, 0f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 5f, 0f);
                    element.To = new Vector3(16f, 16f, 0.01f);
                    element.FaceNorth = new ModelFace("#side", UVMap(0f, 0f, 16f, 11f));
                    element.FaceSouth = new ModelFace("#side", UVMap(16f, 0f, 0f, 11f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 5f, 15.99f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceNorth = new ModelFace("#side", UVMap(16f, 0f, 0f, 11f));
                    element.FaceSouth = new ModelFace("#side", UVMap(0f, 0f, 16f, 11f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0f, 5f, 0f);
                    element.To = new Vector3(0.01f, 16f, 16f);
                    element.FaceWest = new ModelFace("#side", UVMap(0f, 0f, 16f, 11f));
                    element.FaceEast = new ModelFace("#side", UVMap(16f, 0f, 0f, 11f));
                })
                .AddElement(element => {
                    element.From = new Vector3(15.99f, 5f, 0f);
                    element.To = new Vector3(16f, 16f, 16f);
                    element.FaceWest = new ModelFace("#side", UVMap(16f, 0f, 0f, 11f));
                    element.FaceEast = new ModelFace("#side", UVMap(0f, 0f, 16f, 11f));
                })
                .AddElement(element => {
                    element.From = new Vector3(0.1f, 0f, 8f);
                    element.To = new Vector3(15.9f, 15.9f, 8f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceNorth = new ModelFace("#plant", UVFull);
                    element.FaceSouth = new ModelFace("#plant", UVFull);
                })
                .AddElement(element => {
                    element.From = new Vector3(8f, 0f, 0.1f);
                    element.To = new Vector3(8f, 15.9f, 15.9f);
                    element.Rotation = new ModelElementRotation {
                        Origin = new Vector3(8f, 8f, 8f),
                        Axis = ModelAxis.Y,
                        Angle = 45,
                        Rescale = true,
                    };
                    element.FaceWest = new ModelFace("#plant", UVFull);
                    element.FaceEast = new ModelFace("#plant", UVFull);
                });
        }
    }
}
