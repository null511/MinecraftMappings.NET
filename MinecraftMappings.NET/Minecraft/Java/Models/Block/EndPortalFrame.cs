using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EndPortalFrame : JavaBlockModel
    {
        public EndPortalFrame() : base("End Portal Frame")
        {
            AddVersion("end_portal_frame", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("bottom", "block/end_stone")
                .AddTexture("top", "block/end_portal_frame_top")
                .AddTexture("side", "block/end_portal_frame_side")
                .AddElement(element => {
                    element.From = new Vector3(0f, 0f, 0f);
                    element.To = new Vector3(16f, 13f, 16f);
                    element.FaceDown = new ModelFace("#bottom", UVFull);
                    element.FaceUp = new ModelFace("#top", UVFull);
                    element.FaceNorth = new ModelFace("#side") {
                        UV = UVMap(0f, 3f, 16f, 16f),
                    };
                    element.FaceSouth = new ModelFace("#side") {
                        UV = UVMap(0f, 3f, 16f, 16f),
                    };
                    element.FaceWest = new ModelFace("#side") {
                        UV = UVMap(0f, 3f, 16f, 16f),
                    };
                    element.FaceEast = new ModelFace("#side") {
                        UV = UVMap(0f, 3f, 16f, 16f),
                    };
                });
        }
    }
}
