using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DoorBottom : JavaBlockModel
    {
        public DoorBottom() : base("Door, Bottom")
        {
            AddVersion("door_bottom", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(3f, 16f, 16f);
                    element.FaceDown = new ModelFace("#bottom") {
                        UV = UVMap(13f, 0f, 16f, 16f),
                    };
                    element.FaceNorth = new ModelFace("#bottom") {
                        UV = UVMap(3f, 0f, 0f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#bottom") {
                        UV = UVMap(0f, 0f, 3f, 16f),
                    };
                    element.FaceWest = new ModelFace("#bottom") {
                        UV = UVMap(0f, 0f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#bottom") {
                        UV = UVMap(16f, 0f, 0f, 16f),
                    };
                });
        }
    }
}
