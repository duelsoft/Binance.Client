using System;

namespace CryptoTrader.Marketplace.Binance
{
    [Flags]
    public enum BinanceErrorCode
    {
        UNKNOWN = -1000,

        // 10xx - General Server or Network issues
        DISCONNECTED = -1001,
        UNAUTHORIZED = -1002,
        TOO_MANY_REQUESTS = -1003,
        UNEXPECTED_RESP = -1006,
        TIMEOUT = -1007,
        ERROR_MSG_RECEIVED = -1010,
        MIN_NOTIONAL = -1013,
        UNKNOWN_ORDER_COMPOSITION = -1014,
        TOO_MANY_ORDERS = -1015,
        SERVICE_SHUTTING_DOWN = -1016,
        UNSUPPORTED_OPERATION = -1020,
        INVALID_TIMESTAMP = -1021,
        INVALID_SIGNATURE = -1022,

        // 11xx - Request issues
        ILLEGAL_CHARS = -1100,
        TOO_MANY_PARAMETERS = -1101,
        MANDATORY_PARAM_EMPTY_OR_MALFORMED = -1102,
        UNKNOWN_PARAM = -1103,
        UNREAD_PARAMETERS = -1104,
        PARAM_EMPTY = -1105,
        PARAM_NOT_REQUIRED = -1106,
        BAD_PRECISION = -1111,
        NO_DEPTH = -1112,
        TIF_NOT_REQUIRED = -1114,
        INVALID_TIF = -1115,
        INVALID_ORDER_TYPE = -1116,
        INVALID_SIDE = -1117,
        EMPTY_NEW_CL_ORD_ID = -1118,
        EMPTY_ORG_CL_ORD_ID = -1119,
        BAD_INTERVAL = -1120,
        BAD_SYMBOL = -1121,
        INVALID_LISTEN_KEY = -1125,
        MORE_THAN_XX_HOURS = -1127,
        OPTIONAL_PARAMS_BAD_COMBO = -1128,
        INVALID_PARAMETER = -1130,
        NEW_ORDER_REJECTED = -2010,
        CANCEL_REJECTED = -2011,
        NO_SUCH_ORDER = -2013,
        BAD_API_KEY_FMT = -2014,
        REJECTED_MBX_KEY = -2015,
        NO_TRADING_WINDOW = -2016,

        // 9xxx Filter failures
        FILTER_FAILURE_FLAG = -9000
    }
}
