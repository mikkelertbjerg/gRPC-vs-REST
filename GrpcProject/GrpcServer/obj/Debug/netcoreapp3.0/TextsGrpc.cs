// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/texts.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Text
  {
    static readonly string __ServiceName = "Text";

    static readonly grpc::Marshaller<global::GrpcServer.TextId> __Marshaller_TextId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.TextId.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.TextModel> __Marshaller_TextModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.TextModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.EmptyRequest> __Marshaller_EmptyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.EmptyRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.TextId, global::GrpcServer.TextModel> __Method_GetText = new grpc::Method<global::GrpcServer.TextId, global::GrpcServer.TextModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetText",
        __Marshaller_TextId,
        __Marshaller_TextModel);

    static readonly grpc::Method<global::GrpcServer.EmptyRequest, global::GrpcServer.TextModel> __Method_GetAllTexts = new grpc::Method<global::GrpcServer.EmptyRequest, global::GrpcServer.TextModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllTexts",
        __Marshaller_EmptyRequest,
        __Marshaller_TextModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.TextsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Text</summary>
    [grpc::BindServiceMethod(typeof(Text), "BindService")]
    public abstract partial class TextBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.TextModel> GetText(global::GrpcServer.TextId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllTexts(global::GrpcServer.EmptyRequest request, grpc::IServerStreamWriter<global::GrpcServer.TextModel> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TextBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetText, serviceImpl.GetText)
          .AddMethod(__Method_GetAllTexts, serviceImpl.GetAllTexts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TextBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetText, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.TextId, global::GrpcServer.TextModel>(serviceImpl.GetText));
      serviceBinder.AddMethod(__Method_GetAllTexts, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcServer.EmptyRequest, global::GrpcServer.TextModel>(serviceImpl.GetAllTexts));
    }

  }
}
#endregion
