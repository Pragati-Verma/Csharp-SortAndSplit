# Csharp-SortAndSplit
A challenge to parse a string of orders, sort the orders and tag possible errors


Given string:
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";


Rule:
output each "Order ID" in sorted order and tag orders that aren't exactly four characters in length as "- Error"


Expected output:
A345
B123
B177
B179
C15     - Error
C234
C235
G3003   - Error
