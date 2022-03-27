using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EndPortalFrame_Filled : JavaBlockModel
    {
        public EndPortalFrame_Filled() : base("End Portal Frame, Filled")
        {
            AddVersion("end_portal_frame_filled", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block")
                .AddTexture("bottom", "block/end_stone")
                .AddTexture("top", "block/end_portal_frame_top")
                .AddTexture("side", "block/end_portal_frame_side")
                .AddTexture("eye", "block/end_portal_frame_eye")
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
                })
                .AddElement(element => {
                    element.From = new Vector3(4f, 13f, 4f);
                    element.To = new Vector3(12f, 16f, 12f);
                    element.FaceUp = new ModelFace("#eye") {
                        UV = UVMap(4f, 4f, 12f, 12f),
                    };
                    element.FaceNorth = new ModelFace("#eye") {
                        UV = UVMap(4f, 0f, 12f, 3f),
                    };
                    element.FaceSouth = new ModelFace("#eye") {
                        UV = UVMap(4f, 0f, 12f, 3f),
                    };
                    element.FaceWest = new ModelFace("#eye") {
                        UV = UVMap(4f, 0f, 12f, 3f),
                    };
                    element.FaceEast = new ModelFace("#eye") {
                        UV = UVMap(4f, 0f, 12f, 3f),
                    };
                });
        }
    }
}
