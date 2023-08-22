//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public enum pjmedia_tp_proto {
  PJMEDIA_TP_PROTO_NONE = 0,
  PJMEDIA_TP_PROTO_UNKNOWN = 1 << 0,
  PJMEDIA_TP_PROTO_UDP = 1 << 1,
  PJMEDIA_TP_PROTO_RTP = 1 << 2,
  PJMEDIA_TP_PROTO_DTLS = 1 << 3,
  PJMEDIA_TP_PROFILE_RTCP_FB = 1 << 13,
  PJMEDIA_TP_PROFILE_SRTP = 1 << 14,
  PJMEDIA_TP_PROFILE_AVP = 1 << 15,
  PJMEDIA_TP_PROTO_RTP_AVP = PJMEDIA_TP_PROTO_RTP|PJMEDIA_TP_PROFILE_AVP,
  PJMEDIA_TP_PROTO_RTP_SAVP = PJMEDIA_TP_PROTO_RTP_AVP|PJMEDIA_TP_PROFILE_SRTP,
  PJMEDIA_TP_PROTO_DTLS_SRTP = PJMEDIA_TP_PROTO_DTLS|PJMEDIA_TP_PROTO_RTP_SAVP,
  PJMEDIA_TP_PROTO_RTP_AVPF = PJMEDIA_TP_PROTO_RTP_AVP|PJMEDIA_TP_PROFILE_RTCP_FB,
  PJMEDIA_TP_PROTO_RTP_SAVPF = PJMEDIA_TP_PROTO_RTP_SAVP|PJMEDIA_TP_PROFILE_RTCP_FB,
  PJMEDIA_TP_PROTO_DTLS_SRTPF = PJMEDIA_TP_PROTO_DTLS_SRTP|PJMEDIA_TP_PROFILE_RTCP_FB
}
