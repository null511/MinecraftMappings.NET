using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Template_ItemFrame : JavaBlockModel
    {
        public Template_ItemFrame() : base("Template Item Frame")
        {
            AddVersion("template_item_frame", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(3f, 3f, 15.5f);
                    element.To = new Vector3(13f, 13f, 16f);
                    element.FaceNorth = new ModelFace("#back") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#back") {
                        UV = UVMap(3f, 3f, 13f, 13f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 2f, 15f);
                    element.To = new Vector3(14f, 3f, 16f);
                    element.FaceDown = new ModelFace("#wood") {
                        UV = UVMap(2f, 0f, 14f, 1f),
                    };
                    element.FaceUp = new ModelFace("#wood") {
                        UV = UVMap(2f, 15f, 14f, 16f),
                    };
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(2f, 13f, 14f, 14f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(2f, 13f, 14f, 14f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(15f, 13f, 16f, 14f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(0f, 13f, 1f, 14f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 13f, 15f);
                    element.To = new Vector3(14f, 14f, 16f);
                    element.FaceDown = new ModelFace("#wood") {
                        UV = UVMap(2f, 0f, 14f, 1f),
                    };
                    element.FaceUp = new ModelFace("#wood") {
                        UV = UVMap(2f, 15f, 14f, 16f),
                    };
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(2f, 2f, 14f, 3f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(2f, 2f, 14f, 3f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(15f, 2f, 16f, 3f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(0f, 2f, 1f, 3f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(2f, 3f, 15f);
                    element.To = new Vector3(3f, 13f, 16f);
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(13f, 3f, 14f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(2f, 3f, 3f, 13f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(15f, 3f, 16f, 13f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(0f, 3f, 1f, 13f),
                    };
                })
                .AddElement(element => {
                    element.From = new Vector3(13f, 3f, 15f);
                    element.To = new Vector3(14f, 13f, 16f);
                    element.FaceNorth = new ModelFace("#wood") {
                        UV = UVMap(2f, 3f, 3f, 13f),
                    };
                    element.FaceSouth = new ModelFace("#wood") {
                        UV = UVMap(13f, 3f, 14f, 13f),
                    };
                    element.FaceWest = new ModelFace("#wood") {
                        UV = UVMap(15f, 3f, 16f, 13f),
                    };
                    element.FaceEast = new ModelFace("#wood") {
                        UV = UVMap(0f, 3f, 1f, 13f),
                    };
                });
        }
    }
}
