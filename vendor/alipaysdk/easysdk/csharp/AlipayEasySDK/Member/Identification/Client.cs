// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;

using Alipay.EasySDK.Kernel;
using Alipay.EasySDK.Member.Identification.Models;

namespace Alipay.EasySDK.Member.Identification
{
    public class Client : BaseClient
    {

        public Client(Config config): base(config.ToMap())
        { }

        public AlipayUserCertifyOpenInitializeResponse Init(string outerOrderNo, string bizCode, IdentityParam identityParam, MerchantConfig merchantConfig)
        {
            identityParam.Validate();
            merchantConfig.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>()
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>()
                    {
                        {"method", "alipay.user.certify.open.initialize"},
                        {"app_id", _getConfig("appId")},
                        {"timestamp", _getTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", _getSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", _getConfig("signType")},
                        {"app_cert_sn", _getMerchantCertSN()},
                        {"alipay_root_cert_sn", _getAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>()
                    {
                        {"outer_order_no", outerOrderNo},
                        {"biz_code", bizCode},
                        {"identity_param", identityParam},
                        {"merchant_config", merchantConfig},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = _getConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", _getConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = TeaConverter.merge<string>(
                        new Dictionary<string, string>()
                        {
                            {"sign", _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    );
                    request_.Body = TeaCore.BytesReadable(_toUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = _readAsJson(response_, "alipay.user.certify.open.initialize");
                    if (_isCertMode())
                    {
                        if (_verify(respMap, _extractAlipayPublicKey(_getAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(_toRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (_verify(respMap, _getConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(_toRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>()
                    {
                        {"message", "验签失败，请检查支付宝公钥设置是否正确。"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AlipayUserCertifyOpenInitializeResponse> InitAsync(string outerOrderNo, string bizCode, IdentityParam identityParam, MerchantConfig merchantConfig)
        {
            identityParam.Validate();
            merchantConfig.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>()
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>()
                    {
                        {"method", "alipay.user.certify.open.initialize"},
                        {"app_id", _getConfig("appId")},
                        {"timestamp", _getTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", _getSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", _getConfig("signType")},
                        {"app_cert_sn", _getMerchantCertSN()},
                        {"alipay_root_cert_sn", _getAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>()
                    {
                        {"outer_order_no", outerOrderNo},
                        {"biz_code", bizCode},
                        {"identity_param", identityParam},
                        {"merchant_config", merchantConfig},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = _getConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", _getConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = TeaConverter.merge<string>(
                        new Dictionary<string, string>()
                        {
                            {"sign", _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    );
                    request_.Body = TeaCore.BytesReadable(_toUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = _readAsJson(response_, "alipay.user.certify.open.initialize");
                    if (_isCertMode())
                    {
                        if (_verify(respMap, _extractAlipayPublicKey(_getAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(_toRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (_verify(respMap, _getConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(_toRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>()
                    {
                        {"message", "验签失败，请检查支付宝公钥设置是否正确。"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AlipayUserCertifyOpenQueryResponse Query(string certifyId)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>()
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>()
                    {
                        {"method", "alipay.user.certify.open.query"},
                        {"app_id", _getConfig("appId")},
                        {"timestamp", _getTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", _getSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", _getConfig("signType")},
                        {"app_cert_sn", _getMerchantCertSN()},
                        {"alipay_root_cert_sn", _getAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>()
                    {
                        {"certify_id", certifyId},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = _getConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", _getConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = TeaConverter.merge<string>(
                        new Dictionary<string, string>()
                        {
                            {"sign", _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    );
                    request_.Body = TeaCore.BytesReadable(_toUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = _readAsJson(response_, "alipay.user.certify.open.query");
                    if (_isCertMode())
                    {
                        if (_verify(respMap, _extractAlipayPublicKey(_getAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(_toRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (_verify(respMap, _getConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(_toRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>()
                    {
                        {"message", "验签失败，请检查支付宝公钥设置是否正确。"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AlipayUserCertifyOpenQueryResponse> QueryAsync(string certifyId)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>()
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>()
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>()
                    {
                        {"method", "alipay.user.certify.open.query"},
                        {"app_id", _getConfig("appId")},
                        {"timestamp", _getTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", _getSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", _getConfig("signType")},
                        {"app_cert_sn", _getMerchantCertSN()},
                        {"alipay_root_cert_sn", _getAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>()
                    {
                        {"certify_id", certifyId},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = _getConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>()
                    {
                        {"host", _getConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = TeaConverter.merge<string>(
                        new Dictionary<string, string>()
                        {
                            {"sign", _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    );
                    request_.Body = TeaCore.BytesReadable(_toUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = _readAsJson(response_, "alipay.user.certify.open.query");
                    if (_isCertMode())
                    {
                        if (_verify(respMap, _extractAlipayPublicKey(_getAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(_toRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (_verify(respMap, _getConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(_toRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>()
                    {
                        {"message", "验签失败，请检查支付宝公钥设置是否正确。"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AlipayUserCertifyOpenCertifyResponse Certify(string certifyId)
        {
            Dictionary<string, string> systemParams = new Dictionary<string, string>()
            {
                {"method", "alipay.user.certify.open.certify"},
                {"app_id", _getConfig("appId")},
                {"timestamp", _getTimestamp()},
                {"format", "json"},
                {"version", "1.0"},
                {"alipay_sdk", _getSdkVersion()},
                {"charset", "UTF-8"},
                {"sign_type", _getConfig("signType")},
                {"app_cert_sn", _getMerchantCertSN()},
                {"alipay_root_cert_sn", _getAlipayRootCertSN()},
            };
            Dictionary<string, object> bizParams = new Dictionary<string, object>()
            {
                {"certify_id", certifyId},
            };
            Dictionary<string, string> textParams = new Dictionary<string, string>(){};
            string sign = _sign(systemParams, bizParams, textParams, _getConfig("merchantPrivateKey"));
            Dictionary<string, string> response = new Dictionary<string, string>()
            {
                {"body", _generatePage("GET", systemParams, bizParams, textParams, sign)},
            };
            return TeaModel.ToObject<AlipayUserCertifyOpenCertifyResponse>(response);
        }

    }
}
