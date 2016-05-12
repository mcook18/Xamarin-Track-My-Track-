<html><head><title>Execute SQL</title></head>
<body>

<?php
    $uname = $_REQUEST["uname"];
    $pwd = $_REQUEST["pwd"];
	$connectionInfo = array("UID"=>"eparslow18", "pwd"=>"House10319",
							"Database"=> "TrackMyTrackDatabase", "LoginTimeout"=>30, "Encrypt"=>1);
	$serverName= "trackmytrackserver.database.windows.net,1433";
	$conn = sqlsrv_connect($serverName, $connectionInfo) or die(print_r(sqlsrv_errors(), true));
 	$SQL = "select * from userinfo1 where username='".$uname."' and password='".$pwd."';";
 	$res = sqlsrv_query($conn, $SQL)
		or die(print_r( sqlsrv_errors(), true));
	if (sqlsrv_fetch_array($res))
		echo "logged in";
	else
		echo "not logged in";
?>
</body></html>
