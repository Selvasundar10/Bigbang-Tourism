import React, { useState } from "react";
import { Layout, Menu, Button, Drawer, Row, Col } from "antd";
import {
  HomeOutlined,
  UserOutlined,
  SettingOutlined,
  MenuOutlined,
} from "@ant-design/icons";

const { Header } = Layout;

const AgentNavbar = () => {
  const [visible, setVisible] = useState(false);

  const showDrawer = () => {
    setVisible(true);
  };

  const onClose = () => {
    setVisible(false);
  };

  
  return (
    <Layout className="layout">
      <Header style={{ backgroundColor: "orange", padding: 0 }}> {/* Add backgroundColor */}
        <Row justify="space-between" align="middle">
          <Col xs={20} sm={20} md={4}>
            <div
              className="logo"
              style={{ color: "white", paddingLeft: "20px" }}
            >
              My Logo
            </div>
          </Col>
          <Col xs={0} sm={0} md={20}>
            <Menu theme="dark" mode="horizontal" defaultSelectedKeys={["1"]}>
              <Menu.Item key="1" icon={<HomeOutlined />}>
                Home
              </Menu.Item>
              <Menu.Item key="2" icon={<UserOutlined />}>
                Profile
              </Menu.Item>
              <Menu.Item key="3" icon={<SettingOutlined />}>
                Settings
              </Menu.Item>
              <Menu.Item key="4">
                <Button type="primary" style={{ marginRight: "10px" }}>
                  Sign in
                </Button>
                <Button>Sign up</Button>
              </Menu.Item>
            </Menu>
          </Col>
          <Col xs={2} sm={2} md={0}>
            <Button type="primary" onClick={showDrawer}>
              <MenuOutlined />
            </Button>
          </Col>
        </Row>
        <Drawer
          title="Menu"
          placement="right"
          onClick={onClose}
          onClose={onClose}
          visible={visible}
        >
          <Menu mode="vertical" defaultSelectedKeys={["1"]}>
            <Menu.Item key="1" icon={<HomeOutlined />}>
              Home
            </Menu.Item>
            <Menu.Item key="2" icon={<UserOutlined />}>
              Profile
            </Menu.Item>
            <Menu.Item key="3" icon={<SettingOutlined />}>
              Settings
            </Menu.Item>
            <Menu.Item key="4">
              <Button type="primary" style={{ marginRight: "10px" }}>
                Sign in
              </Button>
              <Button>Sign up</Button>
            </Menu.Item>
          </Menu>
        </Drawer>
      </Header>
    </Layout>
  );
};

export default AgentNavbar;