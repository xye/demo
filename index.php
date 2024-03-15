<?php

echo "Please click below link</br>";
$url = "https://www.google.com/";

echo "open in current tab: <a href='{$url}'>click here</a>";
echo "</br>";
echo "</br>";
echo "</br>";
echo "open in a new tab: <a href='{$url}' target='_blank'>click here</a>";

error_log("BEGIN*************headers************************");
$headers =  getallheaders();
foreach($headers as $key=>$val){
  error_log($key . ': '.  $val);
}

error_log("BEGIN*************body************************");

error_log(file_get_contents('php://input'));

error_log("END*************************************");
