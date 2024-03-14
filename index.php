<?php

error_log("BEGIN*************headers************************");
$headers =  getallheaders();
foreach($headers as $key=>$val){
  error_log($key . ': '.  $val);
}

error_log("BEGIN*************body************************");

error_log(file_get_contents('php://input'));

error_log("END*************************************");
