// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grpc/core/stats.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Core {

  /// <summary>Holder for reflection information generated from grpc/core/stats.proto</summary>
  public static partial class StatsReflection {

    #region Descriptor
    /// <summary>File descriptor for grpc/core/stats.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StatsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVncnBjL2NvcmUvc3RhdHMucHJvdG8SCWdycGMuY29yZSImCgZCdWNrZXQS",
            "DQoFc3RhcnQYASABKAESDQoFY291bnQYAiABKAQiLwoJSGlzdG9ncmFtEiIK",
            "B2J1Y2tldHMYASADKAsyES5ncnBjLmNvcmUuQnVja2V0IlsKBk1ldHJpYxIM",
            "CgRuYW1lGAEgASgJEg8KBWNvdW50GAogASgESAASKQoJaGlzdG9ncmFtGAsg",
            "ASgLMhQuZ3JwYy5jb3JlLkhpc3RvZ3JhbUgAQgcKBXZhbHVlIisKBVN0YXRz",
            "EiIKB21ldHJpY3MYASADKAsyES5ncnBjLmNvcmUuTWV0cmljYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Core.Bucket), global::Grpc.Core.Bucket.Parser, new[]{ "Start", "Count" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Core.Histogram), global::Grpc.Core.Histogram.Parser, new[]{ "Buckets" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Core.Metric), global::Grpc.Core.Metric.Parser, new[]{ "Name", "Count", "Histogram" }, new[]{ "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Core.Stats), global::Grpc.Core.Stats.Parser, new[]{ "Metrics" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Bucket : pb::IMessage<Bucket> {
    private static readonly pb::MessageParser<Bucket> _parser = new pb::MessageParser<Bucket>(() => new Bucket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Bucket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Core.StatsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bucket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bucket(Bucket other) : this() {
      start_ = other.start_;
      count_ = other.count_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Bucket Clone() {
      return new Bucket(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private double start_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 2;
    private ulong count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Bucket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Bucket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Start, other.Start)) return false;
      if (Count != other.Count) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Start != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Start);
      if (Count != 0UL) hash ^= Count.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Start != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Start);
      }
      if (Count != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Count);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Start != 0D) {
        size += 1 + 8;
      }
      if (Count != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Count);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Bucket other) {
      if (other == null) {
        return;
      }
      if (other.Start != 0D) {
        Start = other.Start;
      }
      if (other.Count != 0UL) {
        Count = other.Count;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Start = input.ReadDouble();
            break;
          }
          case 16: {
            Count = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Histogram : pb::IMessage<Histogram> {
    private static readonly pb::MessageParser<Histogram> _parser = new pb::MessageParser<Histogram>(() => new Histogram());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Histogram> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Core.StatsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Histogram() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Histogram(Histogram other) : this() {
      buckets_ = other.buckets_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Histogram Clone() {
      return new Histogram(this);
    }

    /// <summary>Field number for the "buckets" field.</summary>
    public const int BucketsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Grpc.Core.Bucket> _repeated_buckets_codec
        = pb::FieldCodec.ForMessage(10, global::Grpc.Core.Bucket.Parser);
    private readonly pbc::RepeatedField<global::Grpc.Core.Bucket> buckets_ = new pbc::RepeatedField<global::Grpc.Core.Bucket>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Grpc.Core.Bucket> Buckets {
      get { return buckets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Histogram);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Histogram other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!buckets_.Equals(other.buckets_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= buckets_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      buckets_.WriteTo(output, _repeated_buckets_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += buckets_.CalculateSize(_repeated_buckets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Histogram other) {
      if (other == null) {
        return;
      }
      buckets_.Add(other.buckets_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            buckets_.AddEntriesFrom(input, _repeated_buckets_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Metric : pb::IMessage<Metric> {
    private static readonly pb::MessageParser<Metric> _parser = new pb::MessageParser<Metric>(() => new Metric());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Metric> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Core.StatsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric(Metric other) : this() {
      name_ = other.name_;
      switch (other.ValueCase) {
        case ValueOneofCase.Count:
          Count = other.Count;
          break;
        case ValueOneofCase.Histogram:
          Histogram = other.Histogram.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Metric Clone() {
      return new Metric(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Count {
      get { return valueCase_ == ValueOneofCase.Count ? (ulong) value_ : 0UL; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Count;
      }
    }

    /// <summary>Field number for the "histogram" field.</summary>
    public const int HistogramFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.Core.Histogram Histogram {
      get { return valueCase_ == ValueOneofCase.Histogram ? (global::Grpc.Core.Histogram) value_ : null; }
      set {
        value_ = value;
        valueCase_ = value == null ? ValueOneofCase.None : ValueOneofCase.Histogram;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      Count = 10,
      Histogram = 11,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Metric);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Metric other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Count != other.Count) return false;
      if (!object.Equals(Histogram, other.Histogram)) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (valueCase_ == ValueOneofCase.Count) hash ^= Count.GetHashCode();
      if (valueCase_ == ValueOneofCase.Histogram) hash ^= Histogram.GetHashCode();
      hash ^= (int) valueCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (valueCase_ == ValueOneofCase.Count) {
        output.WriteRawTag(80);
        output.WriteUInt64(Count);
      }
      if (valueCase_ == ValueOneofCase.Histogram) {
        output.WriteRawTag(90);
        output.WriteMessage(Histogram);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (valueCase_ == ValueOneofCase.Count) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Count);
      }
      if (valueCase_ == ValueOneofCase.Histogram) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Histogram);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Metric other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.Count:
          Count = other.Count;
          break;
        case ValueOneofCase.Histogram:
          if (Histogram == null) {
            Histogram = new global::Grpc.Core.Histogram();
          }
          Histogram.MergeFrom(other.Histogram);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 80: {
            Count = input.ReadUInt64();
            break;
          }
          case 90: {
            global::Grpc.Core.Histogram subBuilder = new global::Grpc.Core.Histogram();
            if (valueCase_ == ValueOneofCase.Histogram) {
              subBuilder.MergeFrom(Histogram);
            }
            input.ReadMessage(subBuilder);
            Histogram = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class Stats : pb::IMessage<Stats> {
    private static readonly pb::MessageParser<Stats> _parser = new pb::MessageParser<Stats>(() => new Stats());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Stats> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Core.StatsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stats() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stats(Stats other) : this() {
      metrics_ = other.metrics_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stats Clone() {
      return new Stats(this);
    }

    /// <summary>Field number for the "metrics" field.</summary>
    public const int MetricsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Grpc.Core.Metric> _repeated_metrics_codec
        = pb::FieldCodec.ForMessage(10, global::Grpc.Core.Metric.Parser);
    private readonly pbc::RepeatedField<global::Grpc.Core.Metric> metrics_ = new pbc::RepeatedField<global::Grpc.Core.Metric>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Grpc.Core.Metric> Metrics {
      get { return metrics_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Stats);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Stats other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!metrics_.Equals(other.metrics_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= metrics_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      metrics_.WriteTo(output, _repeated_metrics_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += metrics_.CalculateSize(_repeated_metrics_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Stats other) {
      if (other == null) {
        return;
      }
      metrics_.Add(other.metrics_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            metrics_.AddEntriesFrom(input, _repeated_metrics_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
