using Eirin.gRPC.Services;

// CORSポリシー名
const string s_AllowAll = "AllowAll";

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
builder.Services.AddCors(o => o.AddPolicy(s_AllowAll, configure =>
{
    configure.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
}));

var app = builder.Build();
// gRPC-Webを使用
app.UseGrpcWeb();
// CORSを使用
app.UseCors();
// gRPCサービスパイプライン構築
app.MapGrpcService<GreeterService>().EnableGrpcWeb().RequireCors(s_AllowAll);

app.MapGet("/", () => "gRPC専用のエンドポイントです");
app.Run();