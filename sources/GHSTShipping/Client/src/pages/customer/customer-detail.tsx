import React, { useEffect, useState } from 'react';
import { Modal, Button, Descriptions, Col, Row, Tag, Checkbox } from 'antd';
import { IShopViewDetailDto } from '@/interface/shop';
import moment from 'moment';
import { CheckboxChangeEvent } from 'antd/es/checkbox';

interface CustomerDetailProps {
  data: IShopViewDetailDto | undefined;
  onChange: (id: string) => void;
}

const CustomerDetail: React.FC<CustomerDetailProps> = ({ data, onChange }) => {
  const [detail, setDetail] = useState<IShopViewDetailDto | undefined>(data);
  const [open, setOpen] = useState(false);

  const showModal = () => {
    setOpen(true);
  };

  const handleClose = () => {
    setOpen(false);
  };

  const handleChangeAllowPublishOrder = (e: CheckboxChangeEvent) => {
    onChange && onChange(detail?.id as string);
  };

  useEffect(() => {
    if (Boolean(data)) {
      setDetail(data);
    } else {
      if (open == true) {
        handleClose();
      }
    }
  }, [data]);

  useEffect(() => {
    if (Boolean(detail)) {
      showModal();
    }
  }, [detail]);

  return (
    <>
      <Modal
        title={<h3 style={{ fontWeight: 'bold', marginBottom: '0' }}>Thông Tin Cửa Hàng</h3>}
        open={open}
        onCancel={handleClose}
        width={"80%"}
        footer={[
          <Button key="close" type="primary" onClick={handleClose}>
            Đóng
          </Button>,
        ]}
      >
        <Row gutter={[16, 16]}>
          <Col span={24}>
            <Descriptions
              bordered
              size="middle"
              column={2} // Force single column layout
              layout="horizontal" // Horizontal layout ensures label left, value right
              labelStyle={{ width: '30%', fontWeight: 'bold' }} // Customize label styling
              contentStyle={{ textAlign: 'right' }} // Align values to the right
            >
              <Descriptions.Item label="Mã Cửa Hàng">{detail?.shopUniqueCode}</Descriptions.Item>
              <Descriptions.Item label="Ngày Đăng Ký">
                {detail?.registerDate ? moment(detail?.registerDate).format('DD/MM/YYYY') : 'Không có'}
              </Descriptions.Item>
              <Descriptions.Item label="Tên Cửa Hàng">{detail?.shopName}</Descriptions.Item>
              <Descriptions.Item label="Chủ Sở Hữu">{detail?.fullName}</Descriptions.Item>
              <Descriptions.Item label="Email">{detail?.email}</Descriptions.Item>
              <Descriptions.Item label="Sức Chứa Hàng Tháng">
                {detail?.avgMonthlyCapacity?.toLocaleString() ?? 'Không có'}
              </Descriptions.Item>
              <Descriptions.Item label="Số Điện Thoại">{detail?.phoneNumber}</Descriptions.Item>
              <Descriptions.Item label="Tên Ngân Hàng">{detail?.bankName}</Descriptions.Item>
              <Descriptions.Item label="Số Tài Khoản">{detail?.bankAccountNumber}</Descriptions.Item>
              <Descriptions.Item label="Chủ Tài Khoản Ngân Hàng">{detail?.bankAccountHolder}</Descriptions.Item>
              <Descriptions.Item label="Địa Chỉ Ngân Hàng">{detail?.bankAddress}</Descriptions.Item>
              <Descriptions.Item label="Cho Phép Đăng Đơn Hàng (Cho phép shop tạo và đẩy đơn sang đơn vị vận chuyển)">
                <Checkbox onChange={handleChangeAllowPublishOrder} checked={detail?.allowPublishOrder ?? false}>
                  Cho phép
                </Checkbox>
              </Descriptions.Item>
              <Descriptions.Item label="Trạng Thái">
                <Tag color={detail?.isVerified ? 'green' : 'warning'}>{detail?.status}</Tag>
              </Descriptions.Item>
            </Descriptions>
          </Col>
        </Row>
      </Modal>
    </>
  );
};

export default CustomerDetail;
