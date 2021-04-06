// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/author.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcStagingDemo.Protos {
  public static partial class Author
  {
    static readonly string __ServiceName = "author.Author";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcStagingDemo.Protos.AuthorRequest> __Marshaller_author_AuthorRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStagingDemo.Protos.AuthorRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcStagingDemo.Protos.AuthorResponse> __Marshaller_author_AuthorResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStagingDemo.Protos.AuthorResponse.Parser));

    static readonly grpc::Method<global::GrpcStagingDemo.Protos.AuthorRequest, global::GrpcStagingDemo.Protos.AuthorResponse> __Method_GetAuthor = new grpc::Method<global::GrpcStagingDemo.Protos.AuthorRequest, global::GrpcStagingDemo.Protos.AuthorResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAuthor",
        __Marshaller_author_AuthorRequest,
        __Marshaller_author_AuthorResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcStagingDemo.Protos.AuthorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Author</summary>
    [grpc::BindServiceMethod(typeof(Author), "BindService")]
    public abstract partial class AuthorBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcStagingDemo.Protos.AuthorResponse> GetAuthor(global::GrpcStagingDemo.Protos.AuthorRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AuthorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAuthor, serviceImpl.GetAuthor).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AuthorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAuthor, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcStagingDemo.Protos.AuthorRequest, global::GrpcStagingDemo.Protos.AuthorResponse>(serviceImpl.GetAuthor));
    }

  }
}
#endregion