using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDC.Application.WMS.Request
{
    public class AddOrUpdSalesDeliveryReq
    {
       
        public string DocNum { get; set; }
        /// <summary>
        /// 帐套ID
        /// </summary>
       
        public string SboId { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
       
        public string UserId { get; set; }

       

        /// <summary>
        /// 过帐时间，由程序更新。
        /// </summary>
       
        public string DocDate { get; set; }

        /// <summary>
        /// 起息日
        /// </summary>
       
        public string DocDueDate { get; set; }

        /// <summary>
        /// 客户/供应商代码
        /// </summary>
       
        public string CardCode { get; set; }

        /// <summary>
        /// 客户/供应商名称
        /// </summary>
       
        public string CardName { get; set; }

        /// <summary>
        /// 收票方
        /// </summary>
       
        public string Address { get; set; }
        /// <summary>
        /// 运达方
        /// </summary>
       
        public string Address2 { get; set; }

        /// <summary>
        /// 税额总计
        /// </summary>
       
        public string VatSum { get; set; }
        /// <summary>
        /// 凭证折扣率
        /// </summary>
       
        public string DiscPrcnt { get; set; }
        /// <summary>
        /// 总计折扣
        /// </summary>
       
        public string DiscSum { get; set; }
        /// <summary>
        /// 总计折扣外币
        /// </summary>
       
        public string DiscSumFC { get; set; }
        /// <summary>
        /// 凭证货币
        /// </summary>
       
        public string DocCur { get; set; }
        /// <summary>
        /// 凭证汇率
        /// </summary>
       
        public string DocRate { get; set; }

        /// <summary>
        /// 凭证总计
        /// </summary>
       
        public string DocTotal { get; set; }
        /// <summary>
        /// 凭证总计外币
        /// </summary>
       
        public string DocTotalFC { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
       
        public string Comments { get; set; }
        /// <summary>
        /// 审核备注
        /// </summary>
       
        public string Remark { get; set; }
        /// <summary>
        /// 付款条款代码
        /// </summary>
       
        public string GroupNum { get; set; }
        /// <summary>
        /// 销售代表
        /// </summary>
       
        public string SlpCode { get; set; }


        /// <summary>
        /// 部分交货（Y代表Yes,N代表No,默认值为Y）
        /// </summary>
       
        public string PartSupply { get; set; }
        /// <summary>
        /// 是否通过银行（Y代表Yes,N代表No,默认值为Y）
        /// </summary>
       
        public string IsBank { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
       
        public string CntctCode { get; set; }
       
        /// <summary>
        /// 单据日期
        /// </summary>
       
        public string TaxDate { get; set; }

        /// <summary>
        /// 标识
        /// </summary>
       
        public string Indicator { get; set; }

        /// <summary>
        /// 运达方代码
        /// </summary>

        public string ShipToCode { get; set; }

        /// <summary>
        /// 许可的经销商号
        /// </summary>
       
        public string LicTradNum { get; set; }
        /// <summary>
        /// 交货方法
        /// </summary>
        public string TrnspCode { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>

        public string PeyMethod { get; set; }
        /// <summary>
        /// 付款到
        /// </summary>
       
        public string PayToCode { get; set; }
        /// <summary>
        /// 业务伙伴参考编号
        /// </summary>
       
        public string NumAtCard { get; set; }
        /// <summary>
        /// 折扣前总计
        /// </summary>
        /// <summary>
        /// 所有者
        /// </summary>
        public string OwnerCode { get; set; }

        public string BeforeDiscSum { get; set; }
        /// <summary>
        /// 发票类别
        /// </summary>
       
        public string U_FPLB { get; set; }
        /// <summary>
        /// 税率
        /// </summary>
       
        public string U_SL { get; set; }

        /// <summary>
        /// 货到付百分比
        /// </summary>
       
        public string GoodsToPro { get; set; }
        /// <summary>
        /// 货到付款日期
        /// </summary>
       
        public string GoodsToDate { get; set; }

        /// <summary>
        /// 业务员
        /// </summary>
        public string U_YWY { get; set; }
        
        /// <summary>
        /// 凭证类型（I & S 默认值为I，I物料、S服务)
        /// </summary>
        public string DocType { get; set; }
        /// <summary>
        /// 货到付款天数
        /// </summary>

        public string GoodsToDay { get; set; }
        /// <summary>
        /// 发货前付
        /// </summary>
       
        public string PayBefShip { get; set; }
        /// <summary>
        /// 预付百分比
        /// </summary>
       
        public string PrepaPro { get; set; }
        /// <summary>
        /// 预付款日期
        /// </summary>
       
        public string PrepaData { get; set; }
        /// <summary>
        /// 自定义字段
        /// </summary>
       
        public string CustomFields { get; set; }
        /// <summary>
        /// WhsCode
        /// </summary>
       
        public string WhsCode { get; set; }
       
        /// <summary>
        /// 标识订单来源，4是从ERP 4.0同步而来，3是默认来源于ERP 3.0， 2是商城已付款订单同步而来 
        /// </summary>
       
        public string U_ERPFrom { get; set; }

        /// <summary>
        /// 设备箱号
        /// </summary>
        public string U_CPH { get; set; }
        /// <summary>
        /// 验收期限
        /// </summary>

        public string U_YSQX { get; set; }

        /// <summary>
        /// 退货原因
        /// </summary>

        public string U_THYY { get; set; }

        /// <summary>
        /// 行明细
        /// </summary>

        public IList<BillSalesDetails> billSalesDetails { get; set; }
        
    }
    public class BillSalesDetails
    {
        /// <summary>
        /// 物料号
        /// </summary>
        
        public string ItemCode { get; set; }

        /// <summary>
        /// 物料/服务描述
        /// </summary>
        
        public string Dscription { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        
        public string Quantity { get; set; }
       
        /// <summary>
        /// 价格
        /// </summary>
        
        public string Price { get; set; }
        /// <summary>
        /// 每行折扣 %
        /// </summary>
        
        public string DiscPrcnt { get; set; }
        /// <summary>
        /// 折扣后价格
        /// </summary>
        
        public string PriceBefDi { get; set; }
        /// <summary>
        /// 税定义
        /// </summary>
        
        public string VatGroup { get; set; }
        /// <summary>
        /// 毛价
        /// </summary>
        
        public string PriceAfVAT { get; set; }
        /// <summary>
        /// 行总计
        /// </summary>
        
        public string LineTotal { get; set; }

        /// <summary>
        /// 以外币计的行总计
        /// </summary>
        
        public string TotalFrgn { get; set; }

        /// <summary>
        /// 销售提成比例
        /// </summary>
        
        public string U_XSTCBL { get; set; }
        /// <summary>
        /// 销售提成金额
        /// </summary>
        
        public string U_XSTCJE { get; set; }

        /// <summary>
        /// 补助金额
        /// </summary>
        
        public string U_BZJE { get; set; }
        /// <summary>
        /// 补助后金额
        /// </summary>
        
        public string U_BZHJE { get; set; }
        /// <summary>
        /// 补助后金额
        /// </summary>
        
        public string Remarks { get; set; }
        /// <summary>
        /// 研发提成金额
        /// </summary>
        
        public string U_YFTCJE { get; set; }
        /// <summary>
        /// 生产提成金额
        /// </summary>
        
        public string U_SCTCJE { get; set; }

        /// <summary>
        /// 物料成本
        /// </summary>
        
        public string StockPrice { get; set; }

        /// <summary>
        /// 业务费
        /// </summary>
        
        public string U_YWF { get; set; }

        /// <summary>
        /// 服务费
        /// </summary>
        
        public string U_FWF { get; set; }

        /// <summary>
        /// 仓库代码
        /// </summary>
        
        public string WhsCode { get; set; }
        /// <summary>
        /// 库存量
        /// </summary>
        
        public string OnHand { get; set; }

        /// <summary>
        /// 每行税收百分比
        /// </summary>
        
        public string VatPrcnt { get; set; }

        
        public string U_TDS { get; set; }
        
        public string U_DL { get; set; }
        
        public string U_DY { get; set; }


        /// <summary>
        /// 目标凭证类型(-1,0,13,16,203,默认值为-1)
        /// </summary>
        
        public string TargetType { get; set; }

        /// <summary>
        /// 目标凭证代码
        /// </summary>
        
        public string TrgetEntry { get; set; }

        /// <summary>
        /// 基本凭证参考
        /// </summary>
        
        public string BaseRef { get; set; }

        /// <summary>
        /// 基本凭证类型(-1,0,23，17，16，13，165,默认值为-1)
        /// </summary>
        
        public string BaseType { get; set; }

        /// <summary>
        /// 基本凭证代码
        /// </summary>
        
        public string BaseEntry { get; set; }

        /// <summary>
        /// 基础行
        /// </summary>
        
        public string BaseLine { get; set; }

        /// <summary>
        /// 配电选项
        /// </summary>
        
        public string U_PDXX { get; set; }
        /// <summary>
        /// 配电选项
        /// </summary>
        
        public string Lowest { get; set; }
        /// <summary>
        /// 配电选项
        /// </summary>
        
        public string ConfigLowest { get; set; }
        /// <summary>
        /// 配电选项
        /// </summary>
        

        public string Deductible { get; set; }
        
        public string WattPrice { get; set; }
        
        public string IsExistMo { get; set; }
        // public string Remarks { get; set; }

        
        public string ItemCfgId { get; set; }
        
        public string IsCommited { get; set; }

        
        public string OnOrder { get; set; }
        
        public string OnAvailable { get; set; }
        
        public string Weight { get; set; }
        
        public string Volume { get; set; }
        
        public string U_JGF { get; set; }
        
        public string U_JGF1 { get; set; }
        
        public string U_YFCB { get; set; }
        //U_SHJSDJ  U_SHJSJ   U_SHTC
        public string U_SHJSDJ { get; set; }
        
        public string U_SHJSJ { get; set; }
        
        public string U_SHTC { get; set; }
        
        public string U_XSTC { get; set; }
        
        public string U_YFTC_CCDC { get; set; }
        
        public string U_YFTC_EVT { get; set; }
        
        public string U_YFTC_4 { get; set; }
        
        public string QryGroup1 { get; set; }
        
        public string QryGroup2 { get; set; }
        
        public string _QryGroup3 { get; set; }
        
        public string Available { get; set; }
        
        public string MinLevel { get; set; }
        
        public string PurPackUn { get; set; }
        
        public string U_KJFY { get; set; }//扣减费用
                                          //  
                                          //  public string U_BZJE { get; set; }//补助金额(已存在)
        
        public string QryGroup8 { get; set; }//3008n
        
        public string QryGroup9 { get; set; }//9系列
        
        public string QryGroup10 { get; set; }//ES系列
        
        public string U_YFTC_3008n { get; set; }//3008n
        
        public string U_YFTC_9 { get; set; }//9系列
        
        public string U_YFTC_ES { get; set; }//ES系列
        
        public string SumQuantity { get; set; }//出货数量(新增)
        
        public string DeliveredQuantity { get; set; }//交货数量(取代SumQuantity)

        
        public string U_RelDoc { get; set; }//采购物料对应的订单情况
        
        public string U_RelQty { get; set; }//采购物料对应的订单数量总计
        
        public string U_ZS { get; set; }//配置类型
        
        public IList<BillSerialNumberChooseItem> ChoosedSerialNumberList { get; set; }

        
        public string LineNum { get; set; }

        
        public string LineStatus { get; set; }
        /// <summary>
        /// 未清数量
        /// </summary>
        
        public string OpenQty { get; set; }
        
    }
}
