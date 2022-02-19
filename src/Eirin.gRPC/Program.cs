using Eirin.gRPC.Services;

// CORS�|���V�[��
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
// gRPC-Web���g�p
app.UseGrpcWeb();
// CORS���g�p
app.UseCors();
// gRPC�T�[�r�X�p�C�v���C���\�z
app.MapGrpcService<GreeterService>().EnableGrpcWeb().RequireCors(s_AllowAll);

app.MapGet("/", () => "gRPC��p�̃G���h�|�C���g�ł�");
app.Run();