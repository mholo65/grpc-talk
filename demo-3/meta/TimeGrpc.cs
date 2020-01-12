// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Time.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Time.Net {
  public static partial class TimeService
  {
    static readonly string __ServiceName = "time.TimeService";

    static readonly grpc::Marshaller<global::Time.Net.SubscribeRequest> __Marshaller_time_SubscribeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Time.Net.SubscribeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Timestamp> __Marshaller_google_protobuf_Timestamp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Timestamp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Time.Net.SyncResponse> __Marshaller_time_SyncResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Time.Net.SyncResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Int32Value> __Marshaller_google_protobuf_Int32Value = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int32Value.Parser.ParseFrom);

    static readonly grpc::Method<global::Time.Net.SubscribeRequest, global::Google.Protobuf.WellKnownTypes.Timestamp> __Method_Subscribe = new grpc::Method<global::Time.Net.SubscribeRequest, global::Google.Protobuf.WellKnownTypes.Timestamp>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Subscribe",
        __Marshaller_time_SubscribeRequest,
        __Marshaller_google_protobuf_Timestamp);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Time.Net.SyncResponse> __Method_Sync = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Time.Net.SyncResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "Sync",
        __Marshaller_google_protobuf_Timestamp,
        __Marshaller_time_SyncResponse);

    static readonly grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Google.Protobuf.WellKnownTypes.Int32Value> __Method_Ping = new grpc::Method<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Google.Protobuf.WellKnownTypes.Int32Value>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Ping",
        __Marshaller_google_protobuf_Timestamp,
        __Marshaller_google_protobuf_Int32Value);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Time.Net.TimeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TimeService</summary>
    [grpc::BindServiceMethod(typeof(TimeService), "BindService")]
    public abstract partial class TimeServiceBase
    {
      public virtual global::System.Threading.Tasks.Task Subscribe(global::Time.Net.SubscribeRequest request, grpc::IServerStreamWriter<global::Google.Protobuf.WellKnownTypes.Timestamp> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Time.Net.SyncResponse> Sync(grpc::IAsyncStreamReader<global::Google.Protobuf.WellKnownTypes.Timestamp> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task Ping(grpc::IAsyncStreamReader<global::Google.Protobuf.WellKnownTypes.Timestamp> requestStream, grpc::IServerStreamWriter<global::Google.Protobuf.WellKnownTypes.Int32Value> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TimeService</summary>
    public partial class TimeServiceClient : grpc::ClientBase<TimeServiceClient>
    {
      /// <summary>Creates a new client for TimeService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TimeServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TimeService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TimeServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TimeServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TimeServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp> Subscribe(global::Time.Net.SubscribeRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subscribe(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp> Subscribe(global::Time.Net.SubscribeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Subscribe, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Time.Net.SyncResponse> Sync(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Sync(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Time.Net.SyncResponse> Sync(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_Sync, null, options);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Google.Protobuf.WellKnownTypes.Int32Value> Ping(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Google.Protobuf.WellKnownTypes.Int32Value> Ping(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Ping, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TimeServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TimeServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TimeServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Subscribe, serviceImpl.Subscribe)
          .AddMethod(__Method_Sync, serviceImpl.Sync)
          .AddMethod(__Method_Ping, serviceImpl.Ping).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TimeServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Subscribe, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Time.Net.SubscribeRequest, global::Google.Protobuf.WellKnownTypes.Timestamp>(serviceImpl.Subscribe));
      serviceBinder.AddMethod(__Method_Sync, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Time.Net.SyncResponse>(serviceImpl.Sync));
      serviceBinder.AddMethod(__Method_Ping, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Protobuf.WellKnownTypes.Timestamp, global::Google.Protobuf.WellKnownTypes.Int32Value>(serviceImpl.Ping));
    }

  }
}
#endregion
