import React, {FC, useRef} from 'react';
import {
  View,
  ScrollView,
  TouchableHighlight,
  Text,
  requireNativeComponent,
  StyleSheet,
  UIManager,
  findNodeHandle,
  AppRegistry,
} from 'react-native';
import {drives, Drive} from '../../data/fake_data';
import Item from '../../components/item/item.component';
import Header from '../../components/header/header.component';
import Section from '../../components/section/section.component';
import Nav from '../../components/nav/nav.component';

const CustomUserControl = requireNativeComponent('CustomUserControl');

const DrivesPage: FC<{navigation: any}> = ({navigation}) => {
  const customControlRef = useRef(null);
  const handlePressItem = (name: string) => {
    console.log(name);
  };
  const handlePressButton = () => {
    console.log('handlePressButton', customControlRef);
    console.log('hello', CustomUserControl);
    if (customControlRef.current) {
      const tag = findNodeHandle(customControlRef.current);
      console.log('tag', tag);
      UIManager.dispatchViewManagerCommand(
        tag,
        UIManager.getViewManagerConfig('CustomUserControl').Commands
          .CustomCommand,
        ['arg1', 'arg2'],
      );
    }
  };
  return (
    <ScrollView>
      <CustomUserControl
        style={styles.customControl}
        label="CustomUserControl asda!"
        ref={customControlRef}
      />
      <Header navigation={navigation} title="Drives" />
      <View style={{backgroundColor: 'black'}}>
        <Nav navigation={navigation} />
      </View>
      <Section title="Drives" mode="row">
        {drives.map((item: Drive) => (
          <Item
            key={item.id}
            src={item.src}
            name={item.name}
            onPress={handlePressItem}
          />
        ))}
      </Section>
      <TouchableHighlight onPress={handlePressButton}>
        <Text style={{color: 'black'}}>Login</Text>
      </TouchableHighlight>
    </ScrollView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: '#F5FCFF',
  },
  customControl: {
    color: '#333333',
    backgroundColor: '#FFEBCD',
    width: 200,
    height: 30,
    margin: 10,
  },
});

//AppRegistry.registerComponent('ViewManagerSample', () => DrivesPage);

export default DrivesPage;
