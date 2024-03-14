<?php

// This file is auto-generated, don't edit it. Thanks.
namespace Alipay\EasySDK\Security\TextRisk\Models;

use AlibabaCloud\Tea\Model;

class AlipaySecurityRiskContentDetectResponse extends Model{
    protected $_name = [
        'httpBody' => 'http_body',
        'code' => 'code',
        'msg' => 'msg',
        'subCode' => 'sub_code',
        'subMsg' => 'sub_msg',
        'action' => 'action',
        'keywords' => 'keywords',
        'uniqueId' => 'unique_id',
    ];
    public function validate() {
        Model::validateRequired('httpBody', $this->httpBody, true);
        Model::validateRequired('code', $this->code, true);
        Model::validateRequired('msg', $this->msg, true);
        Model::validateRequired('subCode', $this->subCode, true);
        Model::validateRequired('subMsg', $this->subMsg, true);
        Model::validateRequired('action', $this->action, true);
        Model::validateRequired('keywords', $this->keywords, true);
        Model::validateRequired('uniqueId', $this->uniqueId, true);
    }
    public function toMap() {
        $res = [];
        $res['http_body'] = $this->httpBody;
        $res['code'] = $this->code;
        $res['msg'] = $this->msg;
        $res['sub_code'] = $this->subCode;
        $res['sub_msg'] = $this->subMsg;
        $res['action'] = $this->action;
        $res['keywords'] = [];
        if(null !== $this->keywords){
            $res['keywords'] = $this->keywords;
        }
        $res['unique_id'] = $this->uniqueId;
        return $res;
    }
    /**
     * @param array $map
     * @return AlipaySecurityRiskContentDetectResponse
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['http_body'])){
            $model->httpBody = $map['http_body'];
        }
        if(isset($map['code'])){
            $model->code = $map['code'];
        }
        if(isset($map['msg'])){
            $model->msg = $map['msg'];
        }
        if(isset($map['sub_code'])){
            $model->subCode = $map['sub_code'];
        }
        if(isset($map['sub_msg'])){
            $model->subMsg = $map['sub_msg'];
        }
        if(isset($map['action'])){
            $model->action = $map['action'];
        }
        if(isset($map['keywords'])){
            if(!empty($map['keywords'])){
                $model->keywords = [];
                $model->keywords = $map['keywords'];
            }
        }
        if(isset($map['unique_id'])){
            $model->uniqueId = $map['unique_id'];
        }
        return $model;
    }
    /**
     * @description 响应原始字符串
     * @var string
     */
    public $httpBody;
    /**
     * @var string
     */
    public $code;
    /**
     * @var string
     */
    public $msg;
    /**
     * @var string
     */
    public $subCode;
    /**
     * @var string
     */
    public $subMsg;
    /**
     * @var string
     */
    public $action;
    /**
     * @var array
     */
    public $keywords;
    /**
     * @var string
     */
    public $uniqueId;
}
