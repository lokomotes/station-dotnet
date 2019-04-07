// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: router.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Loko.Metro.Api {
  public static partial class Router
  {
    static readonly string __ServiceName = "loko.metro.api.Router";

    static readonly grpc::Marshaller<global::Loko.Metro.Api.StartRequest> __Marshaller_loko_metro_api_StartRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.StartRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.Response> __Marshaller_loko_metro_api_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.Response.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.LinkRequest> __Marshaller_loko_metro_api_LinkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.LinkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.BlockRequest> __Marshaller_loko_metro_api_BlockRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.BlockRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.TransmitRequest> __Marshaller_loko_metro_api_TransmitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.TransmitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.ListenRequest> __Marshaller_loko_metro_api_ListenRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.ListenRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Loko.Metro.Api.Signal> __Marshaller_loko_metro_api_Signal = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Loko.Metro.Api.Signal.Parser.ParseFrom);

    static readonly grpc::Method<global::Loko.Metro.Api.StartRequest, global::Loko.Metro.Api.Response> __Method_Start = new grpc::Method<global::Loko.Metro.Api.StartRequest, global::Loko.Metro.Api.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Start",
        __Marshaller_loko_metro_api_StartRequest,
        __Marshaller_loko_metro_api_Response);

    static readonly grpc::Method<global::Loko.Metro.Api.LinkRequest, global::Loko.Metro.Api.Response> __Method_Link = new grpc::Method<global::Loko.Metro.Api.LinkRequest, global::Loko.Metro.Api.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Link",
        __Marshaller_loko_metro_api_LinkRequest,
        __Marshaller_loko_metro_api_Response);

    static readonly grpc::Method<global::Loko.Metro.Api.BlockRequest, global::Loko.Metro.Api.Response> __Method_Block = new grpc::Method<global::Loko.Metro.Api.BlockRequest, global::Loko.Metro.Api.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Block",
        __Marshaller_loko_metro_api_BlockRequest,
        __Marshaller_loko_metro_api_Response);

    static readonly grpc::Method<global::Loko.Metro.Api.TransmitRequest, global::Loko.Metro.Api.Response> __Method_Transmit = new grpc::Method<global::Loko.Metro.Api.TransmitRequest, global::Loko.Metro.Api.Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Transmit",
        __Marshaller_loko_metro_api_TransmitRequest,
        __Marshaller_loko_metro_api_Response);

    static readonly grpc::Method<global::Loko.Metro.Api.ListenRequest, global::Loko.Metro.Api.Signal> __Method_Listen = new grpc::Method<global::Loko.Metro.Api.ListenRequest, global::Loko.Metro.Api.Signal>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Listen",
        __Marshaller_loko_metro_api_ListenRequest,
        __Marshaller_loko_metro_api_Signal);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Loko.Metro.Api.RouterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Router</summary>
    public abstract partial class RouterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Loko.Metro.Api.Response> Start(global::Loko.Metro.Api.StartRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Loko.Metro.Api.Response> Link(global::Loko.Metro.Api.LinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Loko.Metro.Api.Response> Block(global::Loko.Metro.Api.BlockRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Loko.Metro.Api.Response> Transmit(global::Loko.Metro.Api.TransmitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task Listen(global::Loko.Metro.Api.ListenRequest request, grpc::IServerStreamWriter<global::Loko.Metro.Api.Signal> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Router</summary>
    public partial class RouterClient : grpc::ClientBase<RouterClient>
    {
      /// <summary>Creates a new client for Router</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RouterClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Router that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RouterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RouterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RouterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Loko.Metro.Api.Response Start(global::Loko.Metro.Api.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Loko.Metro.Api.Response Start(global::Loko.Metro.Api.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> StartAsync(global::Loko.Metro.Api.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> StartAsync(global::Loko.Metro.Api.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
      }
      public virtual global::Loko.Metro.Api.Response Link(global::Loko.Metro.Api.LinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Link(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Loko.Metro.Api.Response Link(global::Loko.Metro.Api.LinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Link, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> LinkAsync(global::Loko.Metro.Api.LinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> LinkAsync(global::Loko.Metro.Api.LinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Link, null, options, request);
      }
      public virtual global::Loko.Metro.Api.Response Block(global::Loko.Metro.Api.BlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Block(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Loko.Metro.Api.Response Block(global::Loko.Metro.Api.BlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Block, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> BlockAsync(global::Loko.Metro.Api.BlockRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BlockAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> BlockAsync(global::Loko.Metro.Api.BlockRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Block, null, options, request);
      }
      public virtual global::Loko.Metro.Api.Response Transmit(global::Loko.Metro.Api.TransmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Transmit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Loko.Metro.Api.Response Transmit(global::Loko.Metro.Api.TransmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Transmit, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> TransmitAsync(global::Loko.Metro.Api.TransmitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TransmitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Loko.Metro.Api.Response> TransmitAsync(global::Loko.Metro.Api.TransmitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Transmit, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Loko.Metro.Api.Signal> Listen(global::Loko.Metro.Api.ListenRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Listen(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Loko.Metro.Api.Signal> Listen(global::Loko.Metro.Api.ListenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Listen, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RouterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RouterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RouterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Start, serviceImpl.Start)
          .AddMethod(__Method_Link, serviceImpl.Link)
          .AddMethod(__Method_Block, serviceImpl.Block)
          .AddMethod(__Method_Transmit, serviceImpl.Transmit)
          .AddMethod(__Method_Listen, serviceImpl.Listen).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RouterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Start, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Loko.Metro.Api.StartRequest, global::Loko.Metro.Api.Response>(serviceImpl.Start));
      serviceBinder.AddMethod(__Method_Link, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Loko.Metro.Api.LinkRequest, global::Loko.Metro.Api.Response>(serviceImpl.Link));
      serviceBinder.AddMethod(__Method_Block, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Loko.Metro.Api.BlockRequest, global::Loko.Metro.Api.Response>(serviceImpl.Block));
      serviceBinder.AddMethod(__Method_Transmit, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Loko.Metro.Api.TransmitRequest, global::Loko.Metro.Api.Response>(serviceImpl.Transmit));
      serviceBinder.AddMethod(__Method_Listen, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Loko.Metro.Api.ListenRequest, global::Loko.Metro.Api.Signal>(serviceImpl.Listen));
    }

  }
}
#endregion
